using System;
using exercise.webapi.Models;

namespace exercise.webapi.DTO;

public class BookDTO
{
    public int Id { get; set; }
    public string Title { get; set; }
    
    public int AuthorId { get; set; }
    public string PublisherName {get; set;}
    public AuthorGetBookDTO Author { get; set; }


    public BookDTO(Book book)
    {
        Id = book.Id;
        Title = book.Title;
        AuthorId = book.AuthorId;
        PublisherName = book.Publisher.Name;
        Author = new AuthorGetBookDTO(book.Author);
        
        
        

    }
}
