using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Threading.Tasks;

namespace TattooServer.ActionFilters
{
    public class ValidateAppointmentExistsAttribute : IAsyncActionFilter
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public ValidateAppointmentExistsAttribute(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var method = context.HttpContext.Request.Method;
            var trackChanges = (method.Equals("PUT") || method.Equals("PATCH")) ? true : false;

            var id = (Guid)context.ActionArguments["id"];
            var appointment = await _repository.Appointment.GetAppointmentAsync(id, trackChanges);

            if (appointment == null)
            {
                _logger.LogInfo($"Appointment with id {id} doesn't exists in the database");
                context.Result = new NotFoundResult();
            }
            else
            {
                context.HttpContext.Items.Add("Appointment", appointment);
                await next();
            }
        }
    }
}
