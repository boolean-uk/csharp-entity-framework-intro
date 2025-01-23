using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Mapper
{
    public static class MappBook
    {
        public static BookDTO ToBookDto(this Book skillModel)
        {
            return new BookDTO
            {
                Id = skillModel.Id,
                Title = skillModel.Title,
                AuthorId = skillModel.AuthorId,
                Author = skillModel.Author.ToProfileNoListsDto()
            };
        }


        public static Book ToBookFromCreateDto(this AddBookDTO bookDTO)
        {
            return new Book
            {
                Title = bookDTO.Title,
                AuthorId = bookDTO.AuthorId
            };
        }

    }
}
