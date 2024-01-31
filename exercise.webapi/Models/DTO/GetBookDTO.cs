namespace exercise.webapi.Models.DTO
{
    public class GetBookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<AuthorInfoDTO> AuthorInfo { get; set; }
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
    }
}
