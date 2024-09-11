using exercise.webapi.Models;

namespace exercise.webapi.DTOs;

public class PublisherDTO
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}