namespace exercise.webapi.DTO
{
    public class BookDTO
    {
        public int id { get; set; }
        public string title { get; set; }
        public int author_id { get; set; }
        public AuthorDTO author { get; set; }
    }
}
