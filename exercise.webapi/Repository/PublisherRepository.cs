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

        
        public async Task<List<Publisher>> GetAllPublishers()
        {
            return await _db.Publishers.ToListAsync();
        }

        public async Task<PublisherDto> GetPublisher(int id)
        {
            PublisherDto publisher = new();
            Publisher getPublisher = await _db.Publishers.FirstOrDefaultAsync(p => p.Id == id);
            publisher.Id = id;
            publisher.Name = getPublisher.Name;
            foreach (Book book in await _db.Books.Where(b => b.PublisherId == id).ToListAsync())
            {
                BookAuthorDto bookAuthorDto = new();
                bookAuthorDto.Id = book.Id;
                bookAuthorDto.Title = book.Title;
                bookAuthorDto.Author = new();
                foreach(int authorId in book.AuthorId)
                {
                    bookAuthorDto.Author.Add(await _db.Authors.FirstOrDefaultAsync(a => a.Id == authorId));
                }
                publisher.Books.Add(bookAuthorDto);
            }
            return publisher;
        }
    }
}
    

