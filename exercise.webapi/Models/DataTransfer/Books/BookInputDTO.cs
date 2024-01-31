namespace exercise.webapi.Models.DataTransfer.Books
{
    public class BookInputDTO(string Title, int AuthorId)
    {
        public string Title { get; set; } = Title;

        public int AuthorId { get; set; } = AuthorId;
    }
}
