using exercise.webapi.Data;
using exercise.webapi.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class PublisherRepository : IPublisherRepository
    {
        DataContext _db;

        public PublisherRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<GetPublisherDTO>> GetAllPublishers()
        {
            return await _db.Publishers.Select(x => new GetPublisherDTO()
            {
                Id = x.Id,
                Name = x.Name,
                BookInfo = x.Books.Select(y => new BookAuthorDTO() { Title = y.Title, AuthorName = y.Author.FirstName + " " + y.Author.LastName }).ToList(),
            }).ToListAsync();
        }

        public async Task<GetPublisherDTO?> GetPublisherById(int id)
        {
            return await _db.Publishers.Where(x => x.Id == id).Select(x => new GetPublisherDTO()
            {
                Id = x.Id,
                Name = x.Name,
                BookInfo = x.Books.Select(y => new BookAuthorDTO() { Title = y.Title, AuthorName = y.Author.FirstName + " " + y.Author.LastName }).ToList(),
            }).FirstOrDefaultAsync();
        }
    }
}
