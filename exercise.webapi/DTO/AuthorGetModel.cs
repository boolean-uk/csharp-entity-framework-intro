using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class AuthorGetModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<AuthorBookModel> Books { get; set; } = new List<AuthorBookModel>();
    }
}
