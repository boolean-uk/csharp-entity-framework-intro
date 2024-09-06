namespace exercise.webapi.Models
{
    public class BookPost()
    {
        public required string title { get; set; }
        public required ICollection<int> authorId { get; set; }
    }
}


