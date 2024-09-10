namespace exercise.webapi.DTOs
{
    public class BookAuthorDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? AuthorId { get; set; }
        public string Author { get; set; }
    }
}
