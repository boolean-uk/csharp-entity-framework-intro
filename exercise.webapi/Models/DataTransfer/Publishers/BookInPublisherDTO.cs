using exercise.webapi.Models.DatabaseModels;
using exercise.webapi.Models.DataTransfer.Books;

namespace exercise.webapi.Models.DataTransfer.Publishers
{
    public class BookInPublisherDTO(int Id, string Title, Author Author)
    {
        public int Id { get; set; } = Id;
        public string Title { get; set; } = Title;
        public AuthorInBookDTO author { get; set; } = new AuthorInBookDTO(Author.Id, Author.FirstName, Author.LastName, Author.Email);
    }
}
