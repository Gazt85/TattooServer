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

            CreateMap<Product, ProductDto>();
            CreateMap<ProductForCreationDto, Product>();
            CreateMap<ProductForUpdateDto, Product>().ReverseMap();

            CreateMap<Video, VideoDto>();
            CreateMap<VideoForCreationDto, Video>();
            CreateMap<VideoForUpdateDto, Video>().ReverseMap();

            CreateMap<BlogPost, BlogPostDto>();
            CreateMap<BlogPostForCreationDto, BlogPost>();
            CreateMap<BlogPostForUpdateDto, BlogPost>().ReverseMap();

            CreateMap<BlogItem, BlogItemDto>();
            CreateMap<BlogItemForCreationDto, BlogItem>();
            CreateMap<BlogItemForUpdateDto, BlogItem>().ReverseMap();

            CreateMap<AppointmentData, AppointmentDataDto>().
                ForMember(a => a.Subject, opt =>
                opt.MapFrom(x => string.Join(" ", x.FirstName, x.LastName))).
                ForMember(a => a.Location, opt =>
                opt.MapFrom(x => x.Phone)).
                ForMember(a => a.ShortDescription, opt =>
                opt.MapFrom(x => x.TattooDescription)).
                ForMember(a => a.Description, opt =>
                opt.MapFrom(x => $"{x.TattooDescription} - Dimensiones: {x.TattooWidth} X {x.TattooHeight}")).
                ForMember(a => a.PhotoSource, opt =>
                opt.MapFrom(x => x.Photo));


            CreateMap<AppointmentDataForCreationDto, AppointmentData>();
            CreateMap<AppointmentDataForUpdateDto, AppointmentData>().ReverseMap();
        }
    }
}
