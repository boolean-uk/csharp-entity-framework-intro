namespace exercise.webapi.Models.DTO
{
    public class GetAuthorDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> BookTitle { get; set; }
    }
}
