namespace exercise.webapi.Models.InputTypes;

public class BookPost
{
    public string Title { get; set; }
    public ICollection<int> AuthorIds { get; set; }
    public int PublisherId { get; set; }
}
