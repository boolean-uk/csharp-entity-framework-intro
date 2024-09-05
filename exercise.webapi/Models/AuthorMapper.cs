namespace exercise.webapi.Models
{
    public static class AuthorMapper
    {
        public static AuthorDTO MapToDTO(this Author author)
        {
            return new AuthorDTO
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = author.Books.IMapListToDTO()
            };
        }

        public static List<AuthorDTO> MapListToDTO(this List<Author> books)
        {
            return books.Select(author => new AuthorDTO
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = author.Books.IMapListToDTO()
            }).ToList();
        }

        public static ICollection<BookDTO> IMapListToDTO(this ICollection<Book> books)
        {
            return books.Select(book => new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author.MapToDTO(),
                AuthorId = book.AuthorId
            }).ToList();
        }
    }
}
