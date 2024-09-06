namespace exercise.webapi.DTO
{
    public class GetBooksResponse
    {
        public List<BookDTO> Books { get; set; } = new List<BookDTO>();
    }
}
