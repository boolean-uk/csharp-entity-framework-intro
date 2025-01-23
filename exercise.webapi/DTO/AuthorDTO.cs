using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class AuthorDTO
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public List<BookDTO>books { get; set; }
    }
}
