using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.DTOS
{
    public class DTOBookWithAuthor
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DTOAuthorWithoutBooks Author { get; set; }
        public DTOPublisherWithoutBook Publisher { get; set; }
    }
}
