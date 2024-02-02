namespace exercise.webapi.Models.DTO
{
    public class GetAuthorDto
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public ICollection<GetBookDtoNoAuthor> books { get; set; } = new List<GetBookDtoNoAuthor>();
    }
}
