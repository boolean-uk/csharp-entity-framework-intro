namespace exercise.webapi.Models
{
    public class DTBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<string> Authors { get; set; }
        public int PublisherId { get; set; }
        public string PublisherName { get; set;}

    }

}
