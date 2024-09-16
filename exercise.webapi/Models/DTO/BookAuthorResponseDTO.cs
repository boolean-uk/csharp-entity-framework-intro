namespace exercise.webapi.Models.DTO
{
    public class BookAuthorResponseDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public AuthorDTO Author { get; set; }
    }
}
