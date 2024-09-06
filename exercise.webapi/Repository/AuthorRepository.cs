using exercise.webapi.Data;

namespace exercise.webapi.Repository
{
    public class AuthorRepository
    {
        DataContext _db;

        public AuthorRepository(DataContext db)
        {
            _db = db;
        }
    }
}
