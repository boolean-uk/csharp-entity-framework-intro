using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class P_BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int authorID { get; set; }   

        public AuthorDTO Author { get; set; }
        
        public P_BookDTO()
        {
            Author = new AuthorDTO();
        }

    }
}
