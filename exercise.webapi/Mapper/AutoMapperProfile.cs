using AutoMapper;
using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Author, AuthorDto>();
            CreateMap<Author, AuthorResponseDto>();
            CreateMap<Book, BookDto>();
            CreateMap<Book, BookWithoutAuthorDto>();
        }
    }
}
