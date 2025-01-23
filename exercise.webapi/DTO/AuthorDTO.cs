namespace exercise.webapi.DTO
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> BookTitles { get; set; } = new List<string>();

    }
}
