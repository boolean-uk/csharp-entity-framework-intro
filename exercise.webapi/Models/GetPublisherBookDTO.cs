namespace exercise.webapi.Models
{
    public class GetPublisherBookDTO
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public AuthorDTO Author { get; set; }
    }
}
