namespace exercise.webapi.Models
{
    public class BookPut
    {
        public int PublisherId { get; set; }
        public List<int> AuthorIds { get; set; }
    }

}
