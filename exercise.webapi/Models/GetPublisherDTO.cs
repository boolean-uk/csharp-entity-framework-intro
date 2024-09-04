namespace exercise.webapi.Models
{
    public class GetPublisherDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<GetPublisherBookDTO> Books { get; set; }
        

    }
}
