using exercise.webapi.Models;

namespace exercise.webapi.DTOs
{
    public class BookAuthorDTO
    {

        public string Title { get; set; }


        public AuthorDTO Author { get; set; }

        public BookAuthorDTO(BookAuthor bookAuthor)
        {
            Title = bookAuthor.Book.Title; 
            Author = new AuthorDTO(bookAuthor.Author);
        }
    }


    public class AuthorBookDTO
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public BookDTO Book { get; set; }

        public AuthorBookDTO(BookAuthor bookAuthor)
        {
            FirstName = bookAuthor.Author.FirstName;
            LastName = bookAuthor.Author.LastName;
            Email = bookAuthor.Author.Email;
            Book = new BookDTO(bookAuthor.Book);
        }
    }


}
