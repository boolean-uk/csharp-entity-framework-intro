namespace exercise.webapi.DTO
{
    public class BookDTONoPublisher
    {
        public int id { get; set; }
        public string title { get; set; }
        public AuthorDTOnoBooks author { get; set; }
    }
}
