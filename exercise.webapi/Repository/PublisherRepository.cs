using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class PublisherRepository : IPublisherRepository
    {
        DataContext _db;
        public PublisherRepository(DataContext db) 
        {
            this._db = db;
        }

        public async Task<List<Publisher>> GetAll() 
        {
            List<Publisher> publishers = await this._db.Publishers.ToListAsync();
            return publishers;
        }
       
        public async Task<Publisher_DTO> Get(int id) 
        {
            Publisher publisher = await this._db.Publishers.Include(p => p.books).ThenInclude(b => b.Author).SingleAsync(a => a.Id == id);


            Publisher_DTO publisher_DTO = new Publisher_DTO()
            {
                Id = publisher.Id,
                Name = publisher.Name,
                Books = publisher.books.Select(a => new BookDTO
                {
                    Id = a.Id,
                    Title = a.Title,
                    AuthorId = a.AuthorId,
                    Author = new AuthorDTO() 
                    {
                        Id = a.Author.Id,
                        FirstName = a.Author.FirstName,
                        LastName = a.Author.LastName,
                        Email = a.Author.Email,
                    }
                }).ToList()
            };
            return publisher_DTO;
        }
    }
}
