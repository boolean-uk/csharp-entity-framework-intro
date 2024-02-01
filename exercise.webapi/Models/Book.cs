using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class Book
    {
        [Key]
        public int Id { get; internal set; }
        public string Title { get; set; }

        public int AuthorId { get; set; }
    }

}
