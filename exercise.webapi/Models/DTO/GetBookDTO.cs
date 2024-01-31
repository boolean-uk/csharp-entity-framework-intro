namespace exercise.webapi.Models.DTO
{
    public class GetBookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorEmail { get; set; }
    }
}
