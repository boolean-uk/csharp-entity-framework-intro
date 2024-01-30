


namespace exercise.webapi.Models.DTOs {

    public class AuthorResponseDTO {
        public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;} 

        public ICollection<BookAuthorDTO> Books {get; set;} = null!;
    

        public AuthorResponseDTO(Author Author) {
            Id = Author.Id;
            FirstName = Author.FirstName;
            LastName = Author.LastName;
            Books = new List<BookAuthorDTO>();
            foreach (var book in Author.Books)
            {
                Books.Add(new BookAuthorDTO(book.Book));
            }
        }

        public static List<AuthorResponseDTO> FromRepository(IEnumerable<Author> authors) {
             var results = new List<AuthorResponseDTO>();
            foreach (var author in authors)
            {
                results.Add(new AuthorResponseDTO(author));

            }
            return results;
        }
    }


}