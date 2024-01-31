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
                BookAuthorInfo = x.Books.Select(y => new BookAuthorDTO()
                {
                    Title = y.Title,
                    AuthorInfo = y.Authors.Select(z => new AuthorInfoDTO()
                    {
                        AuthorEmail = z.Email,
                        AuthorFirstName = z.FirstName,
                        AuthorId = z.Id,
                        AuthorLastName = z.LastName,
                    }).ToList()
                }).ToList(),
            }).ToListAsync();
        }

        public async Task<GetPublisherDTO?> GetPublisherById(int id)
        {
            return await _db.Publishers.Where(x => x.Id == id).Select(x => new GetPublisherDTO()
            {
                Id = x.Id,
                Name = x.Name,
                BookAuthorInfo = x.Books.Select(y => new BookAuthorDTO()
                {
                    Title = y.Title,
                    AuthorInfo = y.Authors.Select(z => new AuthorInfoDTO()
                    {
                        AuthorEmail = z.Email,
                        AuthorFirstName = z.FirstName,
                        AuthorId = z.Id,
                        AuthorLastName = z.LastName,
                    }).ToList()
                }).ToList(),
            }).FirstOrDefaultAsync();
        }
    }
}
