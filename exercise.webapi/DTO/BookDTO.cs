using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookDTO
    {
     
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<AuthorDTO> Authors { get; set; } = new List<AuthorDTO>();
        public PublisherPlainDTO Publisher { get; set; }

        public BookDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;

            foreach (BookAuthor el in book.BookAuthors)
            {

                Authors.Add(new AuthorDTO(el.Author));
            }
            Publisher = new PublisherPlainDTO(book.Publisher);

        }
    }
}
