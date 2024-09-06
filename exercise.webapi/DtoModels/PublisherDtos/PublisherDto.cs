using exercise.webapi.DtoModels.AuthorApiDtos;
using exercise.webapi.Models;

namespace exercise.webapi.DtoModels.PublisherDtos
{
    public class PublisherDto
    {
        public string Name { get; set; }

        //Can duplicate the BookInAuthorDto here
        public ICollection<BookInPublisherDto> Books { get; set; } = new List<BookInPublisherDto>();
    }
}
