using exercise.webapi.Models;

namespace exercise.webapi.ViewModels
{
    public class BookResponse
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int AuthorId { get; set; }
        public AuthorDTO? Author { get; set; }

        public BookResponse(Book book)
        {
            this.Id = book.Id;
            this.Title = book.Title;
            this.AuthorId = book.AuthorId;
            if (book.Author != null)
            {
                this.Author = new AuthorDTO(book.Author);
            }
        }
        //public int Id { get; set; }
        //public string Title { get; set; }
        //public List<int> AuthorId { get; set; } = new List<int>();
        //public List<AuthorDTO> Author { get; set; } = new List<AuthorDTO>();

        //public BookResponse(Book book)
        //{
        //    this.Id = book.Id;
        //    this.Title = book.Title;
        //    this.AuthorId = book.AuthorId;
        //    foreach (var author in book.Author)
        //    {
        //        this.Author.Add(new AuthorDTO(author));
        //    }
        //}
    }
}
