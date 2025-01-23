using exercise.webapi.Models;
using System.Text.Json.Serialization;

namespace exercise.webapi.DTO
{
    public class AuthorReponseDTO
    {
        public DateTime When { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Deleted";

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public List<BookResponseDTO> Books { get; set; } = new List<BookResponseDTO>();
    }
}
