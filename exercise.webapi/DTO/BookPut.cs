using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookPut
    {
        /*
        public int? Id { get; set; }
        public string? Title { get; set; }
        public Author Author { get; set; }
        */

        public required int AuthorId { get; set; }
    }
}
