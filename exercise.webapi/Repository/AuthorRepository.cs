using System;
using System.Threading.Tasks;
using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Payload;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository;

public class AuthorRepository : IAuthorRepository
{

    DataContext _db;

    public AuthorRepository(DataContext db)
    {
        _db = db;
    }
    public async Task<Payload<AuthorDTO>> GetAuthor(int id)
    {
        Payload<AuthorDTO> payload = new Payload<AuthorDTO>();
        Author author = await _db.Authors.Include(a => a.Books).ThenInclude(b => b.Publisher).FirstOrDefaultAsync(a => a.Id == id);
       

        try
        {
            AuthorDTO authorDTO = new AuthorDTO(author);
            payload.Data = authorDTO;
            return payload;
        }
        catch (Exception)
        {
            payload.GoodResponse = false;
            payload.Message = $"Could not find author with id={id}!";

            return payload;
        }
    }

    public async Task<Payload<IEnumerable<AuthorDTO>>> GetAuthors()
    {
        Payload<IEnumerable<AuthorDTO>> payload = new Payload<IEnumerable<AuthorDTO>>();
        List<Author> authors = await _db.Authors.Include(a => a.Books).ThenInclude(b => b.Publisher).ToListAsync();

        List<AuthorDTO> authorDTOs = new List<AuthorDTO>();

        foreach (Author a in authors)
        {
            authorDTOs.Add(new AuthorDTO(a));
        }

        payload.Data = authorDTOs;

        return payload;
    }
}
