using System.Data.Common;
using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class PublisherRepository: IPublisherRepository
    {
        DataContext _db;

        public PublisherRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<Publisher> CreatePublisher(PublisherCreatePayload payload)
        {
            var publisher = new Publisher() { Company = payload.Company };
            try
            {
                await _db.Publishers.AddAsync(publisher);
                await _db.SaveChangesAsync();
                return publisher;
            }
            catch (DbException ex)
            {
                throw new Exception($"Error creating publisher: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Unexpected error creating publisher: {ex.Message}", ex);
            }
        }

        public async Task<ICollection<Publisher>> GetAllPublishers()
        {
            try
            {
            return await _db.Publishers
                .Include(p => p.Books)
                .ThenInclude(authorBook => authorBook.BookAuthors)
                .ToListAsync();
            }
            catch (DbException ex)
            {
                throw new Exception($"Error retrieving all publishers: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Unexpected error retrieving all publishers: {ex.Message}", ex);
            }
        }

        public async Task<Publisher> GetPublisherById(int id)
        {
            try
            {
            var publisher = await _db.Publishers
            .Include(p => p.Books)
            .ThenInclude(authorBook => authorBook.BookAuthors)
            .Where(p => p.Id == id)
            .FirstOrDefaultAsync();
            return publisher;

            }
            catch (DbException ex)
            {
                throw new Exception($"Error retrieving publisher with ID: {id}: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Unexpected error retrieving publisher with ID: {id}: {ex.Message}", ex);
            }
        }
    }

}
