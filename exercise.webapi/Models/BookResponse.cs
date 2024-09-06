namespace exercise.webapi.Models
{
    public class BookResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public AuthorDTO AuthorDTO { get; set; }

        public BookResponse(int id, string title, int authorid, AuthorDTO dto)
        {
            this.Id = id;
            this.Title = title;
            this.AuthorId = authorid;
            this.AuthorDTO = dto;
        }
    }

   
}
