using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TattooServer.ActionFilters;

namespace TattooServer.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public UsersController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers([FromQuery] UserParameters usersParameters)
        {           
            var users = await _repository.User.GetAllUsersAsync(usersParameters, trackChanges: false);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(users.Metadata));

            var usersDto = _mapper.Map<IEnumerable<UserDto>>(users);

            return Ok(usersDto);
        }

        [HttpGet("{id}", Name = "UserById")]
        public async Task<IActionResult> GetUser(Guid id)
        {
            var user = await _repository.User.GetUserAsync(id, trackChanges: false);

            if (user == null)
            {
                _logger.LogInfo($"User with id: {id} doesn't exists in the database.");
                return NotFound();
            }
            else
            {
                var userDto = _mapper.Map<UserDto>(user);
                return Ok(userDto);
            }
        }


    }
}
