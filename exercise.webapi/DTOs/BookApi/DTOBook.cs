using exercise.webapi.Models;

namespace exercise.webapi.DTOs.BookApi
{
    public class DTOBook
    {
        public DTOBook(string title, DTOAuthor author)
        {
            Title = title;
            Author = author;
        }

        public string Title { get; set; }

        public DTOAuthor Author { get; set; }
    }
}
