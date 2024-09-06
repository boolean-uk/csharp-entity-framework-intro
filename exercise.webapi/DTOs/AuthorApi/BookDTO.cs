namespace exercise.webapi.DTOs.AuthorApi
{
    public class BookDTO
    {
        public BookDTO(string bookTitle)
        {
            BookTitle = bookTitle;
        }

        public string BookTitle { get; set; }
    }
}
