namespace exercise.webapi.Models
{
    public class AuthorResponseDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<BookDTO> Books { get; set; } = new List<BookDTO>();
        public AuthorResponseDTO(Author author)
        {
            Id = author.Id;
            FirstName = author.FirstName;
            LastName = author.LastName;
            Email = author.Email;
            foreach (Book book in author.Books)
            {
                Books.Add(new BookDTO(book));
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


}
