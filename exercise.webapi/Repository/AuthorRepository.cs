using exercise.webapi.Data;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public class AuthorRepository : IAuthorRepository
    {

        private DataContext _dataContext;

        public AuthorRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Author?> GetAuthorById(int id)
        {
            return await _dataContext.Authors.FindAsync(id);
        }
    }
}
