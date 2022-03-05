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
    [Route("api/appointments")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AppointmentsController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAppointments()
        {
            var appointments = await _repository.Appointment.GetAllApointmentsAsync(trackChanges: false);

            var appointmentsDto = _mapper.Map<IEnumerable<AppointmentDataDto>>(appointments);

            return Ok(appointmentsDto);
        }

        [HttpGet("{id}", Name = "AppointmentById")]
        public async Task<IActionResult> GetAppointment(Guid id)
        {
            var appointment = await _repository.Appointment.GetAppointmentAsync(id, trackChanges: false);

            if (appointment == null)
            {
                _logger.LogInfo($"Appointment with id: {id} doesn't exists in the database.");
                return NotFound();
            }
            else
            {
                var apointmentDto = _mapper.Map<AppointmentDataDto>(appointment);
                return Ok(apointmentDto);
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateAppointment([FromBody] AppointmentDataForCreationDto appointment)
        {
            var appointmentEntity = _mapper.Map<AppointmentData>(appointment);

            _repository.Appointment.CreateAppointment(appointmentEntity);

            await _repository.SaveAsync();

            var appointmentToReturn = _mapper.Map<AppointmentDataDto>(appointmentEntity);

            return CreatedAtRoute("AppointmentById", new { id = appointmentToReturn.Id },
                appointmentToReturn);
        }

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateAppointmentExistsAttribute))]
        public async Task<IActionResult> UpdateAppointment(Guid id, [FromBody] AppointmentDataForUpdateDto appointment)
        {
            var appointmentEntity = HttpContext.Items["Appointment"] as AppointmentData;

            _mapper.Map(appointment, appointmentEntity);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPatch("{id}")]
        [ServiceFilter(typeof(ValidateAppointmentExistsAttribute))]
        public async Task<IActionResult> PartiallyUpdateAppointment(Guid id,
            [FromBody] JsonPatchDocument<AppointmentDataForUpdateDto> patchDoc)
        {
            if (patchDoc == null)
            {
                _logger.LogError("patchDoc object sent from the client is null.");
                return BadRequest("patchDoc object is null");
            }

            var appointmentEntity = HttpContext.Items["Appointment"] as AppointmentData;
            var appointmentToPatch = _mapper.Map<AppointmentDataForUpdateDto>(appointmentEntity);

            patchDoc.ApplyTo(appointmentToPatch, ModelState);

            TryValidateModel(appointmentToPatch);

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the patch document.");
                return UnprocessableEntity(ModelState);
            }

            _mapper.Map(appointmentToPatch, appointmentEntity);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidateAppointmentExistsAttribute))]
        public async Task<IActionResult> DeleteAppointment(Guid id)
        {
            var appointment = HttpContext.Items["Appointment"] as AppointmentData;

            _repository.Appointment.DeleteAppointment(appointment);

            await _repository.SaveAsync();

            return NoContent();
        }
    }
}
