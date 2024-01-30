


namespace exercise.webapi.Models.DTOs {

    public class AuthorDTO {
        public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;} 
    

        public AuthorDTO(Author Author) {
            Id = Author.Id;
            FirstName = Author.FirstName;
            LastName = Author.LastName;
        }
    }


}