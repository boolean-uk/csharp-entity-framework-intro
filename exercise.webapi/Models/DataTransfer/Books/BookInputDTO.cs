namespace exercise.webapi.Models.DataTransfer.Books
{
    public class BookInputDTO(string Title, List<int> AuthorId, int PublisherId)
    {
        public string Title { get; set; } = Title;

        public List<int> AuthorId { get; set; } = AuthorId;

        public int PublisherId { get; set; } = PublisherId;
    }
}
