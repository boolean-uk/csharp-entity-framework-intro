using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models.DTO
{
    public class OutputPublisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<OutputBook> Books { get; set; }
    }
}
