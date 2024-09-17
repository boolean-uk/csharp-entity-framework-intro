using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models.DTO
{
    public class OutputAuthor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IEnumerable<OutputBookWithoutAuthor> Books { get; set; }
    }
}
