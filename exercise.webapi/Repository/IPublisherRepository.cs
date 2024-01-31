
using exercise.webapi.Models;
using exercise.webapi.Models.DTOs;

namespace exercise.webapi.Repository
{ 
    public interface IPublisherRepository {

        public Task<ICollection<Publisher>> GetAllPublishers();

        public Task<Publisher> CreatePublisher(PublisherCreatePayload payload);

        public Task<Publisher> GetPublisherById(int Id);


    }
}