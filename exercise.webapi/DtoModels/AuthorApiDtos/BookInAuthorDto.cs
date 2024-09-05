using exercise.webapi.Models;
using System.Text.Json.Serialization;

namespace exercise.webapi.DtoModels.AuthorApiDtos
{
    public class BookInAuthorDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<BookInAuthorDto> Books { get; set; } = new List<BookInAuthorDto>();
    }
}
