namespace exercise.webapi.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Location { get; set; }

        public ICollection<Author> Authors { get; set; } = new List<Author>();
    }
}
