namespace exercise.webapi.Models.DTO
{
    public class PublisherResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookAuthorResponseDTO> Books { get; set; } = new List<BookAuthorResponseDTO>();

    }
}
