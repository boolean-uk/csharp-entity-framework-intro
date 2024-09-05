namespace exercise.webapi.Models.ModelsAuthorAPI
{
    public class AuthorApiAuthorDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ICollection<AuthorApiBookDto> Books { get; set; } = new List<AuthorApiBookDto>();
    }
}
