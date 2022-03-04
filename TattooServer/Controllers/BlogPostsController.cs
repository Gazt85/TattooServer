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
    [Route("api/blogposts")]
    [ApiController]
    public class BlogPostsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public BlogPostsController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetBlogPosts()
        {
            var blogPosts = await _repository.BlogPost.GetAllBlogPostAsync(trackChanges: false);

            var blogpostsDto = _mapper.Map<IEnumerable<BlogPostDto>>(blogPosts);

            return Ok(blogpostsDto);
        }

        [HttpGet("{id}", Name = "BlogPostById")]
        public async Task<IActionResult> GetBlogPost(Guid id)
        {
            var blogPost = await _repository.BlogPost.GetBlogPostAsync(id, trackChanges: false);         

            if (blogPost == null)
            {
                _logger.LogInfo($"BlogPost with id: {id} doesn't exists in the database.");
                return NotFound();
            }
            else
            {
                var blogPostDto = _mapper.Map<BlogPostDto>(blogPost);
                return Ok(blogPostDto);
            }
        }

        //  [HttpGet("{id}", Name = "BlogItemByBlogPost")]
        //public async Task<IActionResult> GetBlogItemByBlogPost(Guid blogPostId,Guid id)
        //{
        //    var blogItem = await _repository.BlogItem.GetBlogItemByBlogPostIdAsync(blogPostId,id, trackChanges: false);

        //    if (blogItem == null)
        //    {
        //        _logger.LogInfo($"BlogItem with id: {id} doesn't exists in the database.");
        //        return NotFound();
        //    }
        //    else
        //    {
        //        var blogItemDto = _mapper.Map<BlogItemDto>(blogItem);
        //        return Ok(blogItemDto);
        //    }
        //}


        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateBlogPost([FromBody] BlogPostForCreationDto blogPost)
        {
            var blogPostEntity = _mapper.Map<BlogPost>(blogPost);

            _repository.BlogPost.CreateBlogPost(blogPostEntity);

            await _repository.SaveAsync();

            var blogPostToReturn = _mapper.Map<BlogPostDto>(blogPostEntity);

            return CreatedAtRoute("BlogPostById", new { id = blogPostToReturn.Id },
                blogPostToReturn);
        }

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateBlogPostExistsAttribute))]
        public async Task<IActionResult> UpdateBlogPost(Guid id, [FromBody] BlogPostForUpdateDto blogPost)
        {
            var blogPostEntity = HttpContext.Items["BlogPost"] as BlogPost;

            _mapper.Map(blogPost, blogPostEntity);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPatch("{id}")]
        [ServiceFilter(typeof(ValidateBlogPostExistsAttribute))]
        public async Task<IActionResult> PartiallyUpdateBlogPost(Guid id,
            [FromBody] JsonPatchDocument<BlogPostForUpdateDto> patchDoc)
        {
            if (patchDoc == null)
            {
                _logger.LogError("patchDoc object sent from the client is null.");
                return BadRequest("patchDoc object is null");
            }

            var blogPostEntity = HttpContext.Items["BlogPost"] as BlogPost;
            var blogPostToPatch = _mapper.Map<BlogPostForUpdateDto>(blogPostEntity);

            patchDoc.ApplyTo(blogPostToPatch, ModelState);

            TryValidateModel(blogPostToPatch);

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the patch document.");
                return UnprocessableEntity(ModelState);
            }

            _mapper.Map(blogPostToPatch, blogPostEntity);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidateBlogPostExistsAttribute))]
        public async Task<IActionResult> DeleteBlogPost(Guid id)
        {
            var blogPost = HttpContext.Items["BlogPost"] as BlogPost;

            _repository.BlogPost.DeleteBlogPost(blogPost);

            await _repository.SaveAsync();

            return NoContent();
        }
    }
}
