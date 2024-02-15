using exercise.webapi.DTOs;
using exercise.webapi.Models;
using Microsoft.Extensions.Hosting;

namespace exercise.webapi.DTOs
{
    public class BookResponseDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<BookAuthorDTO> BookAuthors { get; set; } = new List<BookAuthorDTO>();


        public BookResponseDTO(Book book, bool includeAuthors = false)
        {
            Id = book.Id;
            Title = book.Title;

            foreach (BookAuthor bookAuthor in book.BookAuthors)
            {
                BookAuthors.Add(new BookAuthorDTO(bookAuthor));
            }
        }

     
    }
}



     