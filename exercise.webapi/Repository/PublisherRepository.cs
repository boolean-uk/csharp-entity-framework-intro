using exercise.webapi.Data;
using exercise.webapi.Models;
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

        public async Task<PublisherAndBooksWithAuthorDTO> GetPublisher(int id)
        {
            var publisher = await _db.Publishers.Where(p => p.Id == id).Select(p => new PublisherAndBooksWithAuthorDTO
            {
                FirstName = p.FirstName,
                LastName = p.LastName,
                Books = p.Books.Select(b => new BookAndAuthorDTO
                {
                    BookTitle = b.Title,
                    AuthorName = b.Author.FirstName + " " + b.Author.LastName
                }).ToList()
            }).FirstOrDefaultAsync();
            return publisher;
        }

        public async Task<IEnumerable<PublisherAndBooksWithAuthorDTO>> GetPublishers()
        {

            return await _db.Publishers.Select(p => new PublisherAndBooksWithAuthorDTO()
            {
                FirstName = p.FirstName,
                LastName = p.LastName,
                Books = p.Books.Select(book => new BookAndAuthorDTO { BookTitle = book.Title, AuthorName = book.Author.FirstName + " " + book.Author.LastName }).ToList(),
            }).ToListAsync();
        }
    }
}
