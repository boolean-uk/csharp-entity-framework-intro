namespace exercise.webapi.DTOs
{
    public class PublisherResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<BookResponseDTO> PublishedBooks { get; set; } = new List<BookResponseDTO>();
    }
}
