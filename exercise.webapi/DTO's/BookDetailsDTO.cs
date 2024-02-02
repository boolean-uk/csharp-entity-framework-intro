using exercise.webapi.Models;

namespace exercise.webapi.DTO_s
{
    public class BookDetailsDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorEmail { get; set; }

        public string publisherName { get; set; }
        
    }
}
