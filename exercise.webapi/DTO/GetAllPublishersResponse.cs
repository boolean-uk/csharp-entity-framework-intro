using exercise.webapi.DTOS;

namespace exercise.webapi.DTO
{
    public class GetAllPublishersResponse
    {
        public List<DTOPublisherWithBook> Publishers { get; set; } = new List<DTOPublisherWithBook>();
    }
}
