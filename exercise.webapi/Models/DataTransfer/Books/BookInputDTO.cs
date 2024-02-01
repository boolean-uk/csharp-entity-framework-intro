namespace exercise.webapi.Models.DataTransfer.Books
{
    public class BookInputDTO(string Title, int AuthorId, int PublisherId)
    {
        public string Title { get; set; } = Title;

        public int AuthorId { get; set; } = AuthorId;

        public int PublisherId { get; set; } = PublisherId;
    }
}
