namespace exercise.webapi.Models.DTO
{
    public class CreateBookDTO
    {
        public string Title { get; set; }
        public ICollection<int> AuthorIds { get; set; }
        public int PublisherId { get; set; }
    }
}
