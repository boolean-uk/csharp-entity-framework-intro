


namespace exercise.webapi.Models.DTOs {
    public class BookDTO {
        public int Id {get; set;}

        public string Title {get; set;}

        public PublisherDTO Publisher {get; set;}
    

        public BookDTO(Book book) {
            Id = book.Id;
            Title = book.Title;
            Publisher = new PublisherDTO(book.Publisher);
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