using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models.DTO
{
    public class OutputBookWithoutAuthor
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        public ExternalPublisher Publisher { get; set; }
    }
}
