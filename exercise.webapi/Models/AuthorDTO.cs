namespace exercise.webapi.Models
{
    public class AuthorDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> Books { get; set; } = new List<string>();
    }
}
