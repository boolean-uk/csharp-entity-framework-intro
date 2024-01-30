namespace exercise.webapi.Models
{
    public class BookResponseDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public AuthorDTO Author { get; set; }
        public PublisherDTO Publisher { get; set; }
        public BookResponseDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            Author = new AuthorDTO(book.Author);
            Publisher = new PublisherDTO(book.Publisher);
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
}
