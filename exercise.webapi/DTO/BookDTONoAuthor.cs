namespace exercise.webapi.DTO
{
    public class BookDTONoAuthor
    {
        public int id { get; set; }
        public string title { get; set; }
        public PublisherNoBooks publisher { get; set; }
    }
}
