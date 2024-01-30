using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public AuthorDTO(Author author)
        {
            Id = author.Id;
            FirstName = author.FirstName;
            LastName = author.LastName;
            Email = author.Email;
        }
    }
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public BookDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            AuthorId = book.AuthorId;
        }
    }
    public class GetAuthorDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<BookDTO> Books { get; set; } = new List<BookDTO>();
        public GetAuthorDTO(Author author)
        {
            Id = author.Id;
            FirstName = author.FirstName;
            LastName = author.LastName;
            Email = author.Email;
            Books = new List<BookDTO>();
            foreach (var item in author.Books)
            {
                Books.Add(new BookDTO(item));
            } 
        }
        public static List<GetAuthorDTO> FromRepository(IEnumerable<Author> authors)
        {
            var results = new List<GetAuthorDTO>();
            foreach (var author in authors)
            {
                results.Add(new GetAuthorDTO(author));
            }
            return results;
        }
    }
    public class GetBookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public AuthorDTO Author { get; set; }
        public GetBookDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            AuthorId = book.AuthorId;
            Author = new AuthorDTO(book.Author);
        }
        public static List<GetBookDTO> FromRepository(IEnumerable<Book> books)
        {
            var results = new List<GetBookDTO>();
            foreach (var book in books)
            {
                results.Add(new GetBookDTO(book));
            }
            return results;
        }
    }
}
