namespace exercise.webapi.CreateModels
{
    public class GetAuthorModel
    {
        public string AuthorName { get; set; }
        public List<string> BookTitles { get; set; } = new List<string>();
    }
}
