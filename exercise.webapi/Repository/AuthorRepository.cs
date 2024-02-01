using exercise.webapi.Data;
using exercise.webapi.Models.DTOs;
using exercise.webapi.Models.Types;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Repository;

public class AuthorRepository : IAuthorRepository
{
    DatabaseContext _db;

    public AuthorRepository(DatabaseContext db)
    {
        _db = db;
    }

    public async Task<IEnumerable<AuthorWithBooksDTO>> GetAllAuthors()
    {
        var authors = await _db.Authors.Include(a => a.Books).ToListAsync();
        var returnList = new List<AuthorWithBooksDTO>();
        foreach (var author in authors)
        {
            returnList.Add(AuthorWithBooksDTO.AuthorToDTO(author));
        }
        return returnList;
    }

    public async Task<AuthorWithBooksDTO?> GetAuthorById(int id)
    {
        var author = await _db.Authors.Include(a => a.Books).FirstOrDefaultAsync(x => x.Id == id);
        if (author == null) return null;
        return AuthorWithBooksDTO.AuthorToDTO(author);
    }
}
