using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class AuthorDTO2
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        //public ICollection<BookDTO3> Books { get; set; } = new List<BookDTO3>();    //USING BookDTO3 for avoiding cycle-reference!
        public ICollection<BookDTO> Books { get; set; } = new List<BookDTO>();    //USING BookDTO3 for avoiding cycle-reference!
    }
}
