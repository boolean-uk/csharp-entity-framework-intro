using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int AuthorID { get; set; }

        // Include AuthorDTO to represent the author
        public AuthorDTO Author { get; set; }

        /*
        public BookDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;

            // Map the Author to AuthorDTO
            Author = new AuthorDTO(book.Author);
        }
        */

    }
}
