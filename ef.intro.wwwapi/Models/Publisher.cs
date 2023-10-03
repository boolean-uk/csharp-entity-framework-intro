using System.ComponentModel.DataAnnotations.Schema;

namespace ef.intro.wwwapi.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
    }
}
