using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookGet
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
