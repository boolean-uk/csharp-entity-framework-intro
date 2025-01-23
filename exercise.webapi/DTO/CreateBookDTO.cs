using System;

namespace exercise.webapi.DTO;

public class CreateBookDTO
{
    public string Title { get; set; }
    
    public int AuthorId { get; set; }
}
