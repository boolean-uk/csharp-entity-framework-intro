using exercise.webapi.Data;
using exercise.webapi.Models;
using System.Collections.Generic;

namespace exercise.webapi.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        DataContext _db;

        public AuthorRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Tuple<Author, IEnumerable<Book>>>> GetAllAuthorBooks()
        {
            List<Tuple<Author, IEnumerable<Book>>> result = new List<Tuple<Author, IEnumerable<Book>>>();
            // Get all of the books based on the author ID

            foreach (var author in _db.Authors)
                result.Add(GetAuthorBooks(author.Id));

            return result;
        }

        public Tuple<Author, IEnumerable<Book>> GetAuthorBooks(int authorID)
        {
            return new Tuple<Author, IEnumerable<Book>>(
                _db.Authors.FirstOrDefault(x => x.Id == authorID), 
                _db.Books.Where(x => x.AuthorId == authorID)
                );
        }

    }
}
