using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class DTO
    {
        public class AuthorDTO
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public AuthorDTO(Author author)
            {
                Id = author.Id;
                FirstName = author.FirstName;
                LastName = author.LastName;
            }
        }

        public class BookDTO
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public int authorID { get; set; }
            public string AuthorFirstName { get; set; }
            public string AuthorLastName { get; set; }
            public BookDTO(Book book)
            {
                Id = book.Id;
                Title = book.Title;
                authorID = book.AuthorId;
                AuthorFirstName = book.Author.FirstName;
                AuthorLastName = book.Author.LastName;
            }


        }
    }
}
