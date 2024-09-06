namespace exercise.webapi.Models
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }

        public BookDTO(int id, string title, int authorId)
        {
            Id = id;
            Title = title;
            AuthorId = authorId;
        }
    }
}
