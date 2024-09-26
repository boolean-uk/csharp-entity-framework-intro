using exercise.webapi.Models;
using exercise.webapi.Models.DTOs;

public class BookAuthorResponseDTO {
        public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;} 

        public ICollection<BookAuthor> BookAuthor {get; set;} = null!;
    

        public BookAuthorResponseDTO(BookAuthor Author) {
            Id = Author.AuthorId;
            FirstName = Author.Author.FirstName;
            LastName = Author.Author.LastName;
            BookAuthor = new List<BookAuthor>();
            BookAuthor.Add(Author);
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