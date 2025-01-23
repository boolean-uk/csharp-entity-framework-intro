using System;
using exercise.webapi.Models;

namespace exercise.webapi.DTO;

public class PublisherGetDTO
{

    public int Id {get;set;}
    public string Name {get;set;}
    public List<BookDTO> Books {get;set;} = new List<BookDTO>();


    public PublisherGetDTO(Publisher p)
    {
        Id = p.Id;
        Name = p.Name;
        foreach (Book b in p.Books)
        {
            Books.Add(new BookDTO(b));
        }
    }
}
