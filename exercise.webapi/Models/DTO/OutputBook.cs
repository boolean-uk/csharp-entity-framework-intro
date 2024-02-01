using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models.DTO
{
    public class OutputBook
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int AuthorId { get; set; }

        public ExternalAuthor Author { get; set; }
    }
}
