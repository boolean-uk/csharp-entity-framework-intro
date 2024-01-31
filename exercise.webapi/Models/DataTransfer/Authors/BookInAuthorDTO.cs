namespace exercise.webapi.Models.DataTransfer.Authors
{
    public class BookInAuthorDTO(int id, string Title)
    {
        public int Id { get; set; } = id;

        public string Title { get; set; } = Title;
    }
}
