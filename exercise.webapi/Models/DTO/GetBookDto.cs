namespace exercise.webapi.Models.DTO
{
    public class GetBookDto
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }

        public PublisherForBookDto Publisher { get; set; }
      
    }
}
