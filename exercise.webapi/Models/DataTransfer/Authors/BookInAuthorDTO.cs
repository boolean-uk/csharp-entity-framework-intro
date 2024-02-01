using exercise.webapi.Models.DatabaseModels;
using exercise.webapi.Models.DataTransfer.Books;

namespace exercise.webapi.Models.DataTransfer.Authors
{
    public class BookInAuthorDTO(int id, string Title, Publisher publisher)
    {
        public int Id { get; set; } = id;

        public string Title { get; set; } = Title;

        public PublisherInBookDTO Publisher { get; set; } = new PublisherInBookDTO(publisher.Id, publisher.Name);
    }
}
