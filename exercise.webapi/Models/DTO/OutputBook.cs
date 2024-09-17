using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models.DTO
{
    public class OutputBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        public ExternalAuthor Author { get; set; }
        public ExternalPublisher Publisher { get; set; }
    }

    public class ExternalAuthor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

    public class ExternalPublisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
