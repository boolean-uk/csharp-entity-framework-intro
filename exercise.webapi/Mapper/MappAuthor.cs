using exercise.webapi.DTO;
using exercise.webapi.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace exercise.webapi.Mapper
{
    public static class MappAuthor
    {
        public static AuthorDTO ToProfileNoListsDto(this Author model)
        {
            return new AuthorDTO
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
            };
        }

        public static AuthorListDTO ToAuthorDto(this Author profileModel)
        {
            return new AuthorListDTO
            {
                Id = profileModel.Id,
                FirstName = profileModel.FirstName,
                LastName = profileModel.LastName,
                Email = profileModel.Email,
                Books = profileModel.Books?.Select(s => new BookListDTO
                {
                    Id = s.Id,
                    Title = s.Title,
                    //ProfileId = s.ProfileId
                }).ToList()
            };
        }
    }
}
