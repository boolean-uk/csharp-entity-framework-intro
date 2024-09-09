using exercise.webapi.DTOS;

namespace exercise.webapi.DTO
{
    public class GetAllAuthorsResponse
    {
        public List<DTOAuthorWithBooks> Authors { get; set; } = new List<DTOAuthorWithBooks>();
    }
}
