using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class GetAuthorDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<GetBookDto> Books { get; set; }
    }
}
