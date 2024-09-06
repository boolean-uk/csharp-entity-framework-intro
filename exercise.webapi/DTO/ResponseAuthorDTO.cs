using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class ResponseAuthorDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<BookDTO> Books { get; set; }

        public ResponseAuthorDTO()
        {
            Books = new List<BookDTO>();
        }
    }
}
