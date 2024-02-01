using exercise.webapi.Models.DatabaseModels;

namespace exercise.webapi.Repository
{
    public interface IPublisherRepository
    {
        public Task<IEnumerable<Publisher>> GetAllAuthors();
        public Task<Publisher> GetAAuthor(int id);
    }
}
