namespace exercise.webapi.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        //I will change it in dto but for now it have to stay
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
