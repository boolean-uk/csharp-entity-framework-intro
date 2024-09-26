using exercise.webapi.Models;
using exercise.webapi.Models.DTOs;

public class BookAuthorAndBookDTO {
        public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;} 

        public ICollection<BookDTO> Books {get; set;} = null!;
    

        public BookAuthorAndBookDTO(BookAuthor bookAuthor) {
            Id = bookAuthor.AuthorId;
            FirstName = bookAuthor.Author.FirstName;
            LastName = bookAuthor.Author.LastName;
            Books.Add(new BookDTO(bookAuthor.Book));
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