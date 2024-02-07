namespace exercise.webapi.Models.ModelsBookAPI
{
    public class BookInput
    {
        public string Title { get; set; }
        public IEnumerable<int> AuthorIds { get; set; }

    }
}
