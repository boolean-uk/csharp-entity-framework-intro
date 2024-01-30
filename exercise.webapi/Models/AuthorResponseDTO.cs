namespace exercise.webapi.Models
{
    public class AuthorResponseDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<BookWithPublisher> Books { get; set; } = new List<BookWithPublisher>();
        public AuthorResponseDTO(Author author)
        {
            Id = author.Id;
            FirstName = author.FirstName;
            LastName = author.LastName;
            Email = author.Email;
            foreach (Book book in author.Books)
            {
                Books.Add(new BookWithPublisher(book));
            }
        }
    }

    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public BookDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
        }
    }
    public class BookWithAuthor : BookDTO
    {
        public AuthorDTO Author { get; set; }
        public BookWithAuthor(Book book) : base(book)
        {
            Author = new AuthorDTO(book.Author);
        }
    }

    public class BookWithPublisher : BookDTO
    {
        public PublisherDTO Publisher { get; set; }
        public BookWithPublisher(Book book) : base(book)
        {
            Publisher = new PublisherDTO(book.Publisher);
        }
    }


}
