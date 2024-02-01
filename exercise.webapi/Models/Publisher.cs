namespace exercise.webapi.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public List<Book> PublishedBooks = new List<Book>();
    }
}
