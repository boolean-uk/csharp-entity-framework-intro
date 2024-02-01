using exercise.webapi.Models.DatabaseModels;
using exercise.webapi.Models.DataTransfer.Books;

namespace exercise.webapi.Models.DataTransfer.Publishers
{
    public class BookInPublisherDTO(int Id, string Title, IEnumerable<Author> Authors)
    {
        public int Id { get; set; } = Id;
        public string Title { get; set; } = Title;
        public IEnumerable<AuthorInBookDTO> author { get; set; } = Authors.Select(a => new AuthorInBookDTO(a.Id, a.FirstName, a.LastName, a.Email));
    }
}
