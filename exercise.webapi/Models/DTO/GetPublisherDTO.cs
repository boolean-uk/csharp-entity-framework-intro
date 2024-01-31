namespace exercise.webapi.Models.DTO
{
    public class GetPublisherDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<BookAuthorDTO> BookInfo { get; set; }
    }
}
