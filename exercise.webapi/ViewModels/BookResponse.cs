using exercise.webapi.Models;

namespace exercise.webapi.ViewModels
{
    public class BookResponse
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public List<int> AuthorIds { get; set; } = new List<int>();
        public List<AuthorDTO>? Authors { get; set; } = new List<AuthorDTO>();

        public BookResponse(Book book)
        {
            this.Id = book.Id;
            this.Title = book.Title;
            if(book.BookAuthors != null)
            {
                foreach(var author in book.BookAuthors)
                {
                    this.AuthorIds.Add(author.AuthorId);
                    if(author.Author != null)
                    {
                        this.Authors.Add(new AuthorDTO(author.Author));
                    }
                }
            }
        }
    }
}
