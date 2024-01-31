


namespace exercise.webapi.Models.DTOs {
    public class BookWithoutPublisherDTO {
        public int Id {get; set;}

        public string Title {get; set;}


        public BookWithoutPublisherDTO(Book book) {
            Id = book.Id;
            Title = book.Title;
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