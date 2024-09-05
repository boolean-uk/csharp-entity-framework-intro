using exercise.webapi.Models;

namespace exercise.webapi.ViewModels
{
    public class OutputDTO
    {
        public int bookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public OutputDTO(Book book)
        {
            this.bookId = book.Id;
            this.Title = book.Title;
            this.AuthorId = book.Author.Id;
            this.FirstName = book.Author.FirstName;
            this.LastName = book.Author.LastName;
            this.Email = book.Author.Email;
        }
    }
}
