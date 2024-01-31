using exercise.webapi.Data;
using exercise.webapi.Models;
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
            returnList.Add(AuthorToDTO(author));
        }
        return returnList;
    }

    public async Task<AuthorWithBooksDTO?> GetAuthorById(int id)
    {
        var author = await _db.Authors.Include(a => a.Books).FirstOrDefaultAsync(x => x.Id == id);
        if (author == null) return null;
        return AuthorToDTO(author);
    }

    private AuthorWithBooksDTO AuthorToDTO(Author author)
    {
        var books = author.Books;
        var booksDTO = new List<BookDTO>();
        foreach (var book in books)
        {
            booksDTO.Add(BookToDTO(book));
        }

        return new AuthorWithBooksDTO()
        {
            FirstName = author.FirstName,
            LastName = author.LastName,
            Email = author.Email,
            Books = booksDTO,
        };
    }

    private BookDTO BookToDTO(Book book)
    {
        return new BookDTO() { Title = book.Title };
    }
}
