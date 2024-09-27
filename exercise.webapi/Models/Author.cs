using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Models
{
    [Table("authors")]
    public class Author
    {
        [Column("author_id")]
        public int Id { get; set; }

        [Column("firstname")]
        public string FirstName { get; set; }

        [Column("lastname")]
        public string LastName { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("books")]
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }

    public class AuthorDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<BookInAuthorDto> Books { get; set; } = new List<BookInAuthorDto>();
        public AuthorDto(Author author)
        {
            Name = $"{author.FirstName} {author.LastName}";
            Email = author.Email;
        }
    }

    public class AuthorInBookDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public AuthorInBookDto(Author author)
        {
            Name = $"{author.FirstName} {author.LastName}";
            Email = author.Email;
        }
    }
}
