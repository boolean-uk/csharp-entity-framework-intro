using exercise.webapi.DTOS;

namespace exercise.webapi.DTO
{
    public class DTOPublisherWithBook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<DTOBookWithAuthor> Books { get; set; } = new List<DTOBookWithAuthor>();
    }
}
