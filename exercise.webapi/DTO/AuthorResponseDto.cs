namespace exercise.webapi.DTO
{
    public class AuthorResponseDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<BookWithoutAuthorDto> Books { get; set; } = new List<BookWithoutAuthorDto>();
    }
}
