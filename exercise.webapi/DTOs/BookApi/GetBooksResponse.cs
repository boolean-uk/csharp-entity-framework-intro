namespace exercise.webapi.DTOs.BookApi
{
    public class GetBooksResponse
    {
        public List<DTOBook> Books { get; set; } = new List<DTOBook>();
    }
}
