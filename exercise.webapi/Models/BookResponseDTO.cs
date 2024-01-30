namespace exercise.webapi.Models
{
    public class BookResponseDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public AuthorDTO Author { get; set; }
        public BookResponseDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            Author = new AuthorDTO(book.Author);
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
}
