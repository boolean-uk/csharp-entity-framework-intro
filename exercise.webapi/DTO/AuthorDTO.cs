using System;
using exercise.webapi.Models;

namespace exercise.webapi.DTO;

public class AuthorDTO
{
    public int Id {get; set;}
    public string FirstName {get;set;}
    public string LastName {get;set;}
    public string Email {get;set;}
    public ICollection<Tuple<string, string>> PublisherBooks {get;set;} = new List<Tuple<string, string>>();

    public AuthorDTO(Author author)
    {
        Id = author.Id;
        FirstName = author.FirstName;
        LastName = author.LastName;
        Email = author.Email;
        foreach (Book b in author.Books)
        {
            PublisherBooks.Add(new Tuple<string, string>(b.Title, b.Publisher.Name));
        }
    }
}
