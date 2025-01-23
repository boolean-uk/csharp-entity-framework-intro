namespace exercise.webapi.DTO
{
    public class AuthorPostDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<BookPostDTO> Books { get; set; }
    }
}
