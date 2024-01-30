using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
     public class AuthorDto{
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string Email { get; set; }

        public AuthorDto(Author author)
        {
            Id = author.Id;
            FirstName = author.FirstName;
            LastName = author.LastName;
            Email = author.Email;
        }
    }
    
    public class BookResponseDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public AuthorDto Author { get; set; }

        public BookResponseDto(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            Author = new AuthorDto(book.Author);
        }

        public static List<BookResponseDto> FromRepository(IEnumerable<Book> books)
        {
        var results = new List<BookResponseDto>();
        foreach (var book in books)
        {
            results.Add(new BookResponseDto(book));
        }
        return results;
        }
    }

}