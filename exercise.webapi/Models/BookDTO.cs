using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Models
{
    public class BookDTO
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }

        public PublisherDTO Publisher { get; set; }
    }
}
