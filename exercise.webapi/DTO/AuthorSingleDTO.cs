using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class AuthorSingleDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ICollection<BookPublisherDTO> Books { get; set; } = new List<BookPublisherDTO>();

        public AuthorSingleDTO(Author author) 
        {
            Id = author.Id;
            FirstName = author.FirstName;
            LastName = author.LastName;
            Email = author.Email;

            Books = new List<BookPublisherDTO>();
            foreach (BookAuthor item in author.BookAuthors)
            {
                Books.Add(new BookPublisherDTO(item.Book));
            }
        }  
    }
}
