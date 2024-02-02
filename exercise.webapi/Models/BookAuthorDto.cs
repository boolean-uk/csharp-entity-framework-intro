namespace exercise.webapi.Models
{
    public class BookAuthorDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public AuthorPlainDto Author { get; set;} 
    }
}
