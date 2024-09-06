using exercise.webapi.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.DTO
{
    public class BookPostModel
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
    }
}
