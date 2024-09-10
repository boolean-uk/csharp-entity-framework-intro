namespace exercise.webapi.DTOs
{
    public class BookDTO()
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<string> Authors { get; set; }
        public int PublisherId { get; set; }
        public string Publisher { get; set; }
    }
}
