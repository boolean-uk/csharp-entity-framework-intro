using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef.intro.wwwapi.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();
    }
}