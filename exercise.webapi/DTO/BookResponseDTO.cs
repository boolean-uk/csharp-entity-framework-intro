using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookResponseDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public AuthorDTO Author { get; set; }

        // constructor
        // Book book is passed into the contructor and copy over the data that you want to copy over.
        public BookResponseDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
        // Creates a new Author with the data you want to copy over in AuthorDTO
            Author = new AuthorDTO(book.Author);
        }

        // converts them into the list of Book DTO's (from BookApi)
        public static List<BookResponseDTO> FromRepository(IEnumerable<Book> books)
        {
            var results = new List<BookResponseDTO>();
            foreach (var book in books)
            {
                // this calls the constructor to get the books
                results.Add(new BookResponseDTO(book));
                // then it will be stored back in to results because of the .Add method
            }
            return results;
        }
    }
}
