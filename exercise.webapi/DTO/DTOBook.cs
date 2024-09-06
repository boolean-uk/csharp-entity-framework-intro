using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class DTOBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }

        public static List<DTOBook> bookToDTO(List<Book> books)
        {
            List<DTOBook> dto = new List<DTOBook>();

            for (int i = 0; i < books.Count - 1; i++)
            {
                DTOBook book = new DTOBook();

                book.Id = books[i].Id;
                book.Title = books[i].Title;
                book.AuthorId = books[i].AuthorId;
                dto.Add(book);
            }
            return dto;
        }

    }
}
