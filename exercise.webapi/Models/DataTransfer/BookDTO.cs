namespace exercise.webapi.Models.DataTransfer
{
    public class BookDTO
    {
        public string Title { get; set; }
        public AuthorDTO Author { get; set; }

        public BookDTO(string title, AuthorDTO author)
        {
            Title = title;
            Author = author;
        }
    }
}
