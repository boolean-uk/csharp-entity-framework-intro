namespace exercise.webapi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IList<int> AuthorIds { get; set; } = new List<int>();
        public IList<Author> Authors { get; set; } = new List<Author>();
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }
}
