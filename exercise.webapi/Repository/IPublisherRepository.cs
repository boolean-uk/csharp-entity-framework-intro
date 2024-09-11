using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IPublisherRepository
    {
        Task<Publisher> GetPublisherById(int id);
        Task<List<Publisher>> GetAllPublishers();
    }
}
