using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Models
{
    [Keyless]
    [NotMapped]
    public class BookDTO
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
    }
}
