using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IManyRepository
    {
        public Task<IEnumerable<BookAuthor>> GetAllRelationships();

        public Task<BookAuthor?> GetRelationship(int authorId, int bookId);

        public Task<BookAuthor> AddRelationship(BookAuthor ba);

        public void SaveChanges();
    }
}
