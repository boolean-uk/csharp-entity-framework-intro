using exercise.webapi.Models;
using System.Text.Json.Serialization;

namespace exercise.webapi.DTO
{
    public class DTOAuthorWithoutBooks
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
