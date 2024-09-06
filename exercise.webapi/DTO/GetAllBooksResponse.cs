using exercise.webapi.DTOS;

namespace exercise.webapi.DTO
{
    public class GetAllBooksResponse
    {
        public List<DTOBookWithAuthor> Books { get; set; } = new List<DTOBookWithAuthor>();
    }
}
