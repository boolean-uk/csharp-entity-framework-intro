using exercise.webapi.Models.DatabaseModels;

namespace exercise.webapi.Models
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public AuthorDto Author { get; set; }
    }
}
