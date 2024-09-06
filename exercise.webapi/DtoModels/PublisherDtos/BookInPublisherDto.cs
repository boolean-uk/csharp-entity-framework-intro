using exercise.webapi.DtoModels.BookApiDtos;

namespace exercise.webapi.DtoModels.PublisherDtos
{
    public class BookInPublisherDto
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public BookAuthorDto Author { get; set; }

    }
}
