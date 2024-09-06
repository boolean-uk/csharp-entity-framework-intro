using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public int AuthorId { get; set; }

        public static List<BookDTO> bookToDTO(List<Book> books)
        {
            List<BookDTO> dto = new List<BookDTO>();

            for(int i = 0; i < books.Count-1; i++)
            {
                BookDTO book = new BookDTO();

                book.Id = books[i].Id;
                book.Title = books[i].Title;
                book.AuthorId = books[i].AuthorId;
                dto.Add(book);
            }
            return dto;
        }
    }
}


