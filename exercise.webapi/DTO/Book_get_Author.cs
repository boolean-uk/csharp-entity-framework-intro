using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class Book_get_Author
    {
        public Book_get_Author(Author author)
        {
            this.Id = author.Id;
            this.FirstName = author.FirstName;
            this.LastName = author.LastName;
            this.Email = author.Email;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

    }
}
