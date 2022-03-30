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
using Entities.RequestFeatures;
using Newtonsoft.Json;

namespace TattooServer.Controllers
{
    [Route("api/clients")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ClientsController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetClients([FromQuery] UserParameters userParameters)
        {
            var clients = await _repository.User.GetAllClientsAsync(userParameters, trackChanges: false);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(clients.Metadata));

            var clientsDto = _mapper.Map<IEnumerable<UserDto>>(clients);

            return Ok(clientsDto);
        }

        [HttpGet("{id}", Name = "ClientById")]
        public async Task<IActionResult> GetClient(Guid id)
        {
            var client = await _repository.Client.GetClientAsync(id, trackChanges: false);

            if (client == null)
            {
                _logger.LogInfo($"Client with id: {id} doesn't exists in the database.");
                return NotFound();
            }
            else
            {
                var clienDto = _mapper.Map<ClientDto>(client);
                return Ok(clienDto);
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateClient([FromBody] ClientForCreationDto client)
        {
            var clientEntity = _mapper.Map<Client>(client);

            _repository.Client.CreateClient(clientEntity);

            await _repository.SaveAsync();

            var clientToReturn = _mapper.Map<ClientDto>(clientEntity);

            return CreatedAtRoute("ClientById", new { id = clientToReturn.Id },
                clientToReturn);
        }

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateClientExistsAttribute))]
        public async Task<IActionResult> UpdateClient(Guid id, [FromBody] ClientForUpdateDto client)
        {
            var clientEntity = HttpContext.Items["Client"] as Client;

            _mapper.Map(client, clientEntity);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPatch("{id}")]
        [ServiceFilter(typeof(ValidateClientExistsAttribute))]
        public async Task<IActionResult> PartiallyUpdateClient(Guid id,
          [FromBody] JsonPatchDocument<ClientForUpdateDto> patchDoc)
        {
            if (patchDoc == null)
            {
                _logger.LogError("patchDoc object sent from the client is null.");
                return BadRequest("patchDoc object is null");
            }

            var clientEntity = HttpContext.Items["Client"] as Client;
            var clientToPatch = _mapper.Map<ClientForUpdateDto>(clientEntity);

            patchDoc.ApplyTo(clientToPatch, ModelState);

            TryValidateModel(clientToPatch);

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the patch document.");
                return UnprocessableEntity(ModelState);
            }

            _mapper.Map(clientToPatch, clientEntity);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidateClientExistsAttribute))]
        public async Task<IActionResult> DeleteClient(Guid id)
        {
            var client = HttpContext.Items["Client"] as Client;

            _repository.Client.DeleteClient(client);

            await _repository.SaveAsync();

            return NoContent();
        }
    }
}
