namespace exercise.webapi.Models.DTO
{
    public class AuthorResponseDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<BookResponseDTO> Books { get; set; } = new List<BookResponseDTO>();
    }
}
