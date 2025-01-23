using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class Author_get
    {
        public Author_get(Author author)
        {
            this.Id = author.Id;
            this.FirstName = author.FirstName;
            this.LastName = author.LastName;
            this.Email = author.Email;
            this.Books = author.Books.Select(x => new Author_get_Book(x)).ToList();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ICollection<Author_get_Book> Books { get; set; } = new List<Author_get_Book>();

    }
}
