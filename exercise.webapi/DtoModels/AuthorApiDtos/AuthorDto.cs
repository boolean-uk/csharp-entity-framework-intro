using exercise.webapi.Models;
using System.Text.Json.Serialization;

namespace exercise.webapi.DtoModels.AuthorApiDtos
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<BookInAuthorDto> Books { get; set; } = new List<BookInAuthorDto>();

        public AuthorDto(Author author)
        {
            Id = author.Id;
            FirstName = author.FirstName;
            LastName = author.LastName;
            Email = author.Email;

            foreach(var b in author.Books)
            {
                Books.Add(new BookInAuthorDto(b, b.Publisher.Name));
            }
        }
    }
}
