using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        /*
        public async Task<Author> GetAuthorById(int authorId)
        {
            var author = await _db.Authors.FindAsync(authorId);
            return author;
        }
        */
        public Task<IEnumerable<Book>> GetAllAuthors()
        {
            throw new NotImplementedException();
        }

        public Task<Author> GetAuthorById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
