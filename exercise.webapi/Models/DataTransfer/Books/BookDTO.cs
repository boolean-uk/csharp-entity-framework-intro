using exercise.webapi.Models.DatabaseModels;

namespace exercise.webapi.Models.DataTransfer.Books
{
    public class BookDTO(int Id, string Title, IEnumerable<Author> Authors, Publisher publisher)
    {
        public int Id { get; set; } = Id;
        public string Title { get; set; } = Title;

        public IEnumerable<AuthorInBookDTO> Author { get; set; } = Authors.Select(a => new AuthorInBookDTO(a.Id, a.FirstName, a.LastName, a.Email));

        public PublisherInBookDTO publisher { get; set; } = new PublisherInBookDTO(publisher.Id, publisher.Name);
    }
}
