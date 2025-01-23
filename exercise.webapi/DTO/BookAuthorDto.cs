using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookAuthorDto
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public BookAuthorDto(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}
