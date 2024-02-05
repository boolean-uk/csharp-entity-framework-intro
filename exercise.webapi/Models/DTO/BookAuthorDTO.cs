namespace exercise.webapi.Models.DTO
{
    public class BookAuthorDTO
    {
        public string Title { get; set; }
        public IEnumerable<AuthorInfoDTO> AuthorInfo { get; set; }
    }
}
