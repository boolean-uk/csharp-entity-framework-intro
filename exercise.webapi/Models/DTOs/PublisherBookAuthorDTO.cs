


namespace exercise.webapi.Models.DTOs {

    public class PublisherBookAuthorDTO {
        public int Id {get; set;}

        public string Company {get; set;}
        public List<BookAuthorResponseDTO> BookAuthor {get; set;}

        public PublisherBookAuthorDTO(Publisher publisher) {
            Id = publisher.Id;
            Company = publisher.Company;
            BookAuthor = new List<BookAuthorResponseDTO>();
            foreach (var book in publisher.Books)
            {
                BookAuthor.Add(new BookAuthorResponseDTO(book));
            }
        }

        public static List<BookAuthorResponseDTO> FromRepository(IEnumerable<BookAuthor> authors) {
             var results = new List<BookAuthorResponseDTO>();
            foreach (var author in authors)
            {
                results.Add(new BookAuthorResponseDTO(author));

            }
            return results;
        }
    }


}