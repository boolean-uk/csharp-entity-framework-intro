using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class PublisherDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PublisherDTO(Publisher publisher)
        {
            Id = publisher.Id;
            Name = publisher.Name;
        } 
    }
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
        public int PublisherId { get; set; }
        public BookDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            AuthorId = book.AuthorId;
            PublisherId = book.PublisherId;
        }
    }
    public class GetPublisherDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<GetBookForPublisherDTO> Books { get; set; } = new List<GetBookForPublisherDTO>();
        public GetPublisherDTO(Publisher publisher)
        {
            Id = publisher.Id;
            Name = publisher.Name;
            Books = new List<GetBookForPublisherDTO>();
            foreach (var item in publisher.Books)
            {
                Books.Add(new GetBookForPublisherDTO(item));
            }
        }
        public static List<GetPublisherDTO> FromRepository(IEnumerable<Publisher> publishers)
        {
            var results = new List<GetPublisherDTO>();
            foreach (var publisher in publishers)
            {
                results.Add(new GetPublisherDTO(publisher));
            }
            return results;
        }
    }
    public class GetAuthorDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<GetBookForAuthorDTO> Books { get; set; } = new List<GetBookForAuthorDTO>();
        public GetAuthorDTO(Author author)
        {
            Id = author.Id;
            FirstName = author.FirstName;
            LastName = author.LastName;
            Email = author.Email;
            Books = new List<GetBookForAuthorDTO>();
            foreach (var item in author.Books)
            {
                Books.Add(new GetBookForAuthorDTO(item));
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
        public int PublisherId { get; set; }
        public PublisherDTO Publisher { get; set; }
        public AuthorDTO Author { get; set; }
        public GetBookDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            AuthorId = book.AuthorId;
            PublisherId = book.PublisherId;
            Publisher = new PublisherDTO(book.Publisher);
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
    public class GetBookForPublisherDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public AuthorDTO Author { get; set; }
        public GetBookForPublisherDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            AuthorId = book.AuthorId;
            Author = new AuthorDTO(book.Author);
        }
    }
    public class GetBookForAuthorDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublisherId { get; set; }
        public PublisherDTO Publisher { get; set; }
        public GetBookForAuthorDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            PublisherId = book.PublisherId;
            Publisher = new PublisherDTO(book.Publisher);
        }
    }
}
