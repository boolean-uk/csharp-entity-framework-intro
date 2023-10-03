using AutoMapper;
using ef.intro.wwwapi.Models;
using ef.intro.wwwapi.Models.DTOs;

namespace ef.intro.wwwapi.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDTO>()
                .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author.FirstName + " " + src.Author.LastName))
                .ForMember(dest => dest.PublisherName, opt => opt.MapFrom(src => src.Publisher.Name));
        }
    }
}
