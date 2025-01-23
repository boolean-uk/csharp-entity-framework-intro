using System;
using exercise.webapi.DTO;
using exercise.webapi.Payload;

namespace exercise.webapi.Repository;

public interface IPublisherRepository
{
    public Task<Payload<List<PublisherGetDTO>>> GetPublishers();

    public Task<Payload<PublisherGetDTO>> GetPublisher(int id);
}
