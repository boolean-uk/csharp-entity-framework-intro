using System;
using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Payload;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository;

public class PublisherRepository : IPublisherRepository
{

    DataContext _db;

    public PublisherRepository(DataContext db)
    {
        _db = db;
    }

    public async Task<Payload<PublisherGetDTO>> GetPublisher(int id)
    {
        Payload<PublisherGetDTO> payload = new Payload<PublisherGetDTO>();
        Publisher publisher = await _db.Publishers.Include(p => p.Books).ThenInclude(b => b.Author).FirstOrDefaultAsync(pub => pub.Id == id);

        try
        {
            payload.Data = new PublisherGetDTO(publisher);
            return payload;
        }
        catch (Exception)
        {
            payload.GoodResponse = false;
            payload.Message = $"Could not find publisher with id={id}";
            return payload;
        }

    }

    public async Task<Payload<List<PublisherGetDTO>>> GetPublishers()
    {
        Payload<List<PublisherGetDTO>> payload = new Payload<List<PublisherGetDTO>>();

        List<Publisher> publishers = await _db.Publishers.Include(p => p.Books).ThenInclude(b => b.Author).ToListAsync();

        List<PublisherGetDTO> pgDTO = new List<PublisherGetDTO>();

        foreach (Publisher p in publishers)
        {
            pgDTO.Add(new PublisherGetDTO(p));
        }

        payload.Data = pgDTO;

        return payload;
    }
}
