namespace exercise.webapi.DTO
{
    public class AuthorResponseDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public List<BookDTO> Books { get; set; }

        public AuthorResponseDTO()
        {
            Books = new List<BookDTO>();    
        }

    }
}