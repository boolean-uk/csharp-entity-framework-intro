namespace exercise.webapi.Models.DTO
{
    public class Book_DTO_3
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int AuthorId { get; set; }
        public AuthorDTO Author { get; set; }
        public Publisher Publisher { get; set; }
    }
}
