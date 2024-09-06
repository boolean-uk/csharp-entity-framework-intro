using exercise.webapi.DtoModels.AuthorApiDtos;
using exercise.webapi.DtoModels.BookApiDtos;
using exercise.webapi.Models;

namespace exercise.webapi.DtoModels.PublisherDtos
{
    public class PublisherDto
    {
        public string Name { get; set; }

        //Can duplicate the BookInAuthorDto here
        public ICollection<BookInPublisherDto> Books { get; set; } = new List<BookInPublisherDto>();

        public PublisherDto(Publisher publisher)
        {
            Name = publisher.Name;
            foreach(var b in publisher.Books)
            {
                Books.Add(new BookInPublisherDto(b, new BookAuthorDto(b.Author)));
            }
        }
    }
}
