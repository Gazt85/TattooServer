using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TattooServer.ActionFilters;

namespace TattooServer.Controllers
{
    [Route("api/videos")]
    [ApiController]
    public class VideosController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public VideosController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetVideos()
        {
            var videos = await _repository.Video.GetAllVideosAsync(trackChanges: false);

            var videosDto = _mapper.Map<IEnumerable<VideoDto>>(videos);

            return Ok(videosDto);
        }

        [HttpGet("{id}", Name = "VideoById")]
        public async Task<IActionResult> GetVideo(Guid id)
        {
            var video = await _repository.Video.GetVideoAsync(id, trackChanges: false);

            if (video == null)
            {
                _logger.LogInfo($"Video with id: {id} doesn't exists in the database.");
                return NotFound();
            }
            else
            {
                var videoDto = _mapper.Map<VideoDto>(video);
                return Ok(videoDto);
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateVideo([FromBody] VideoForCreationDto video)
        {
            var videoEntity = _mapper.Map<Video>(video);

            _repository.Video.CreateVideo(videoEntity);

            await _repository.SaveAsync();

            var videoToReturn = _mapper.Map<VideoDto>(videoEntity);

            return CreatedAtRoute("VideoById", new { id = videoToReturn.Id },
                videoToReturn);
        }


        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateVideoExistsAttribute))]
        public async Task<IActionResult> UpdateVideo(Guid id, [FromBody] VideoForUpdateDto video)
        {
            var videoEntity = HttpContext.Items["Video"] as Video;

            _mapper.Map(video, videoEntity);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPatch("{id}")]
        [ServiceFilter(typeof(ValidateVideoExistsAttribute))]
        public async Task<IActionResult> PartiallyUpdateVideo(Guid id,
            [FromBody] JsonPatchDocument<VideoForUpdateDto> patchDoc)
        {
            if (patchDoc == null)
            {
                _logger.LogError("patchDoc object sent from the client is null.");
                return BadRequest("patchDoc object is null");
            }

            var videoEntity = HttpContext.Items["Video"] as Video;
            var videoToPatch = _mapper.Map<VideoForUpdateDto>(videoEntity);

            patchDoc.ApplyTo(videoToPatch, ModelState);

            TryValidateModel(videoToPatch);

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the patch document.");
                return UnprocessableEntity(ModelState);
            }

            _mapper.Map(videoToPatch, videoEntity);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidateVideoExistsAttribute))]
        public async Task<IActionResult> DeleteVideo(Guid id)
        {
            var video = HttpContext.Items["Video"] as Video;

            _repository.Video.DeleteVideo(video);

            await _repository.SaveAsync();

            return NoContent();
        }
    }
}
