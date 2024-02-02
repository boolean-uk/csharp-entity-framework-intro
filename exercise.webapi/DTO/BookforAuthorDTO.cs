using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookforAuthorDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public AuthorDTO Author { get; set; }
    }
}

