using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class NewBookDTO
    {
       
        public string Title { get; set; }
        public int AuthorId { get; set; }
        //public Author Author { get; set; }
    }
}
