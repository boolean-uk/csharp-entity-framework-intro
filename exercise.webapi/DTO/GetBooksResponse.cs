namespace exercise.webapi.DTO
{
    public class GetBooksResponse
    {
        public List<BookPublisherDTO> Books { get; set; } = new List<BookPublisherDTO>();
    }
}
