namespace exercise.webapi.Models
{
    public static class ResponseGenerator
    {

        public static BookResponse GenerateBookResponse(Book book)
        {
            AuthorDTO aDTO = new AuthorDTO(book.Author.Id, book.Author.FirstName, book.Author.LastName, book.Author.Email);
            BookResponse bRESP = new BookResponse(book.Id, book.Title, book.AuthorId, aDTO);
            return bRESP;
        }

        public static AuthorResponse GenerateAuthorResponse(Author author)
        {
            List<BookDTO> books = new List<BookDTO>();
            foreach (var book in author.Books)
            {
                BookDTO bDTO = new BookDTO(book.Id, book.Title, book.AuthorId);
                books.Add(bDTO);
            }

            AuthorResponse aRESP = new AuthorResponse(author.Id, author.FirstName, author.LastName, author.Email, books);
            return aRESP;
        }
    }
}
