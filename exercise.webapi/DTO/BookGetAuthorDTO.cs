using System;
using exercise.webapi.Models;

namespace exercise.webapi.DTO;

public class BookGetAuthorDTO
{
    public int Id {get;set;}
    public string Title {get;set;}

    public BookGetAuthorDTO(Book b)
    {
        Id = b.Id;
        Title = b.Title;
    }
}
