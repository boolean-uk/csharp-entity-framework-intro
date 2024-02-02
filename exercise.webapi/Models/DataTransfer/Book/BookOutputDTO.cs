using exercise.webapi.Models.DataTransfer.Author;

namespace exercise.webapi.Models.DataTransfer.Book
{
    public class BookOutputDTO
    {
        public string Title { get; set; }
        public AuthorDTO Author { get; set; }

        public BookOutputDTO(string title, AuthorDTO author)
        {
            Title = title;
            Author = author;
        }
    }
}
