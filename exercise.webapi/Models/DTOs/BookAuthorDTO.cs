


namespace exercise.webapi.Models.DTOs {
    public class BookAuthorDTO {
        public int Id {get; set;}

        public string Title {get; set;}

        public PublisherDTO Publisher {get; set;}
    

        public BookAuthorDTO(Book bookAuthor) {
            Id = bookAuthor.Id;
            Title = bookAuthor.Title;
            Publisher = new PublisherDTO(bookAuthor.Publisher);
        }

        public static List<BookDTO> FromRepository(IEnumerable<Book> Books) {
             var results = new List<BookDTO>();
            foreach (var book in Books)
            {
                results.Add(new BookDTO(book));

            }
            return results;
        }
    }


}