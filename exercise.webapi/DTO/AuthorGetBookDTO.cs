using System;
using exercise.webapi.Models;

namespace exercise.webapi.DTO;

public class AuthorGetBookDTO
{

    public int Id {get; set;}
    public string FirstName {get;set;}
    public string LastName {get;set;}
    public string Email {get;set;}

    public AuthorGetBookDTO(Author author)
    {
        Id = author.Id;
        FirstName = author.FirstName;
        LastName = author.LastName;
        Email = author.Email;
    }
}
