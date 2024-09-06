using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public static class DTOMapper
    {
        public static DTOBook MapToDTO(this Book book)
        {
            return new DTOBook
            {
                Id = book.Id,
                Title = book.Title,
                AuthorName = book.Author.FirstName + " " + book.Author.LastName,
                AuthorId = book.AuthorId
            };
        }


        public static List<DTOBook> MapListToDTO(this List<Book> books)
        {
            return books.Select(book => new DTOBook
            {
                Id = book.Id,
                Title = book.Title,
                AuthorName = book.Author.FirstName + " " + book.Author.LastName,
                AuthorId = book.AuthorId
            }).ToList();
        }


    }
}
