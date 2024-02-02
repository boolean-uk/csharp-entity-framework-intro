using exercise.webapi.Models.DataTransfer.Book;

namespace exercise.webapi.Models.DataTransfer.Author
{
    public class AuthorDetailedDTO
    {
        public AuthorDetailedDTO(BaseModels.Author author)
        {
            ID = author.ID;
            FirstName = author.FirstName;
            LastName = author.LastName;
            Email = author.Email;
            foreach (var book in author.Books)
            {
                this.Books.Add(new BookWithPublisherDTO(book));
            }
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<BookWithPublisherDTO> Books { get; set; } = new List<BookWithPublisherDTO>();
    }
}
