using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TattooServer
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UserForCreationDto, User>();
            CreateMap<UserForUpdateDto, User>();

            CreateMap<Client, ClientDto>()
                .ForMember(c => c.FullName,
                opt => opt.MapFrom(x => string.Join(" ", x.FirstName, x.LastName)));
            CreateMap<ClientForCreationDto, Client>();
            CreateMap<ClientForUpdateDto, Client>().ReverseMap();


        }
    }
}
