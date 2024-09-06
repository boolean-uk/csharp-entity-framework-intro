namespace exercise.webapi.ViewModels
{
    public class InputDTO
    {
        public string? Title { get; set; }
        public List<int> AuthorIds { get; set; } = new List<int>();
    }
}
