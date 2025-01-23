using System.Text.Json.Serialization;
using exercise.webapi.Models;

namespace exercise.webapi.Dto;

public class BookResponse
{
    public int Id { get; set; }
    public string Title { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public AuthorResponse? Author { get; set; }
    
    public BookResponse(Book book)
    {
        Id = book.Id;
        Title = book.Title;
        // TODO: Throws NullReferenceException when not in the if statement. FIX!
        if (book.Author is not null)
        {
            Author = new AuthorResponse(book.Author);
        }
    }
}