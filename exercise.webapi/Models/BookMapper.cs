namespace exercise.webapi.Models
{
    public static class BookMapper
    {
        public static BookDTO MapToDTO(this Book book)
        {
            return new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author.IMapToDTO(),
                AuthorId = book.AuthorId,
                PublisherId = book.PublisherId,
                Publisher = book.Publisher.MapToDTO()
            };
        }

        public static List<BookDTO> MapListToDTO(this List<Book> books)
        {
            return books.Select(book => new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author.IMapToDTO(),
                AuthorId = book.AuthorId,
                PublisherId = book.PublisherId,
                Publisher = book.Publisher.MapToDTO()
            }).ToList();
        }
    }
}
