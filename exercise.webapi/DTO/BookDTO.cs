using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookDTO
    {
        public int id { get; set; }
        public string title { get; set; }
      
        public AuthorDTOnoBooks author { get; set; }
        public PublisherNoBooks publisher { get; set; }
    }
}
