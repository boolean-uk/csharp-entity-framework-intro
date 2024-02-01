using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models.DTO
{
    public class ExternalAuthor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
