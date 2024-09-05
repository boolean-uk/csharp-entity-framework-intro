using exercise.webapi.Data;
using exercise.webapi.DTO;
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
        private async Task<List<PublisherBookModel>> CreateBookList(ICollection<Book> books)
        {
            var booksGet = new List<PublisherBookModel>();
            foreach (var book in books)
            {
                await _db.Entry(book).Reference(b => b.Author).LoadAsync();
                booksGet.Add(new PublisherBookModel()
                {
                    Title = book.Title,
                    Author = new BookAuthorModel()
                    {
                        FirstName = book.Author.FirstName,
                        LastName = book.Author.LastName,
                        Email = book.Author.Email
                    } 
                });
            }
            return booksGet;
        }

        private async Task<PublisherGetModel> CreatePublisherModel(Publisher publisher)
        {
            return new PublisherGetModel
            {
                Name = publisher.Name,
                Books = await CreateBookList(publisher.Books)
            };
        }

        public async Task<IEnumerable<PublisherGetModel>> GetAllPublishers()
        {
            var result = await _db.Publishers.Include(p => p.Books).ToListAsync();
            var publishers = new List<PublisherGetModel>();
            foreach (var publisher in result)
            {
                publishers.Add(await CreatePublisherModel(publisher));
            }
            return publishers;
        }

        public async Task<PublisherGetModel> GetPublisher(int id)
        {
            var result = await _db.Publishers.Include(p => p.Books).FirstOrDefaultAsync(p => p.Id == id);
            return await CreatePublisherModel(result);
        }
    }
}
