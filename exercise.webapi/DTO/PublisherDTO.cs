namespace exercise.webapi.DTO
{
    public class PublisherDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookAuthorDTO> Books { get; set; }
    }
}
