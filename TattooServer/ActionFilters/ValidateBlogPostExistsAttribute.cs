using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Threading.Tasks;

namespace TattooServer.ActionFilters
{
    public class ValidateBlogPostExistsAttribute : IAsyncActionFilter
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public ValidateBlogPostExistsAttribute(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var method = context.HttpContext.Request.Method;
            var trackChanges = (method.Equals("PUT") || method.Equals("PATCH")) ? true : false;

            var id = (Guid)context.ActionArguments["id"];
            var blogPost = await _repository.BlogPost.GetBlogPostAsync(id, trackChanges);

            if (blogPost == null)
            {
                _logger.LogInfo($"BlogPost with id {id} doesn't exists in the database");
                context.Result = new NotFoundResult();
            }
            else
            {
                context.HttpContext.Items.Add("BlogPost", blogPost);
                await next();
            }
        }
    }
}
