namespace exercise.webapi.DTOs
{
    public class GetPublisherDTO
    {
        public string Name { get; set; }
        public List<GetBookPublisherDTO> Books { get; set; }
    }
}
