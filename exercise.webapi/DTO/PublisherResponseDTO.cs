namespace exercise.webapi.DTO
{
    public class PublisherResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<P_BookDTO> Books { get; set; }

        public PublisherResponseDTO()
        {
            Books = new List<P_BookDTO>();    
        }

    }
}