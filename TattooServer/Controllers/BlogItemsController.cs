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
    [Route("api/blogitems")]
    [ApiController]
    public class BlogItemsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public BlogItemsController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetBlogItem()
        {
            var blogItems = await _repository.BlogItem.GetAllBlogItemAsync(trackChanges: false);

            var blogItemsDto = _mapper.Map<IEnumerable<BlogItemDto>>(blogItems);

            return Ok(blogItemsDto);
        }

        [HttpGet("{id}", Name = "BlogItemById")]
        public async Task<IActionResult> GetBlogItem(Guid id)
        {
            var blogItem = await _repository.BlogItem.GetBlogItemAsync(id, trackChanges: false);

            if (blogItem == null)
            {
                _logger.LogInfo($"BlogItem with id: {id} doesn't exists in the database.");
                return NotFound();
            }
            else
            {
                var blogItemDto = _mapper.Map<BlogItemDto>(blogItem);
                return Ok(blogItemDto);
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateBlogItem([FromBody] BlogItemForCreationDto blogItem)
        {
            var blogItemEntity = _mapper.Map<BlogItem>(blogItem);

            _repository.BlogItem.CreateBlogItem(blogItemEntity);

            await _repository.SaveAsync();

            var blogItemToReturn = _mapper.Map<BlogItemDto>(blogItemEntity);

            return CreatedAtRoute("BlogItemById", new { id = blogItemToReturn.Id }, blogItemToReturn);
        }


        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateBlogItemExistsAttribute))]
        public async Task<IActionResult> UpdateBlogItem(Guid id, [FromBody] BlogItemForUpdateDto blogItem)
        {
            var blogItemEntity = HttpContext.Items["BlogItem"] as BlogItem;

            _mapper.Map(blogItem, blogItemEntity);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPatch("{id}")]
        [ServiceFilter(typeof(ValidateBlogItemExistsAttribute))]
        public async Task<IActionResult> PartiallyUpdateBlogItem(Guid id,
            [FromBody] JsonPatchDocument<BlogItemForUpdateDto> patchDoc)
        {
            if (patchDoc == null)
            {
                _logger.LogError("patchDoc object sent from the client is null.");
                return BadRequest("patchDoc object is null");
            }

            var blogItemEntity = HttpContext.Items["BlogItem"] as BlogItem;
            var blogItemToPatch = _mapper.Map<BlogItemForUpdateDto>(blogItemEntity);

            patchDoc.ApplyTo(blogItemToPatch, ModelState);

            TryValidateModel(blogItemToPatch);

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the patch document.");
                return UnprocessableEntity(ModelState);
            }

            _mapper.Map(blogItemToPatch, blogItemEntity);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidateBlogItemExistsAttribute))]
        public async Task<IActionResult> DeleteBlogItem(Guid id)
        {
            var blogItem = HttpContext.Items["BlogItem"] as BlogItem;

            _repository.BlogItem.DeleteBlogItem(blogItem);

            await _repository.SaveAsync();

            return NoContent();
        }
    }
}
