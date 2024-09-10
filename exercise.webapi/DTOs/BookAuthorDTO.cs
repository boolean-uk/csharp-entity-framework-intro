namespace exercise.webapi.DTOs
{
    public class BookAuthorDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<string> Authors { get; set; }
    }
}
