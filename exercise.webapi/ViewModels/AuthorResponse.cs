using exercise.webapi.Models;

namespace exercise.webapi.ViewModels
{
    public class AuthorResponse
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public List<BookDTO> Books { get; set; } = new List<BookDTO>();

        public AuthorResponse(Author author)
        {
            this.Id = author.Id;
            this.FirstName = author.FirstName;
            this.LastName = author.LastName;
            this.Email = author.Email;
            if(author.BookAuthors != null)
            {
                foreach (var item in author.BookAuthors)
                {
                    if(item.Book != null)
                    {
                        this.Books.Add(new BookDTO(item.Book));
                    }
                }
            }
        }
    }
}
