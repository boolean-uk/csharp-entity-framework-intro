namespace exercise.webapi.DTO
{
    public class AuthorPutDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<BookPutDTO> Books { get; set; }
    }
}
