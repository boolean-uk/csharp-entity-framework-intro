using exercise.webapi.Data;
using exercise.webapi.DTOs;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class PublisherRepository : IPublisherRepository
    {
        DataContext _context;
        public PublisherRepository(DataContext context)
        {
            _context = context;
        }

        private async Task<List<GetBookPublisherDTO>> GetBookPublisherDTOs(Publisher publisher)
        {
            List<GetBookPublisherDTO> bookDTOs = await _context.Books
                .Include(b => b.Author)
                .Where(b => b.PublisherId == publisher.Id)
                .Select(b => new GetBookPublisherDTO()
                {
                    Id = b.Id,
                    Title = b.Title,
                    Author = b.Author
                })
                .ToListAsync();
            return bookDTOs;
        }

        public async Task<ICollection<GetPublisherDTO>> GetAll()
        {
            List<GetPublisherDTO> publishers = await _context.Publishers
                .Include(p => p.Books)
                .Select(p => new GetPublisherDTO()
                {
                    Name = p.Name,
                    Books = p.Books.Select(b => new GetBookPublisherDTO() { Author = b.Author, Id = b.Id, Title = b.Title }).ToList()
                })
                .ToListAsync();
            return publishers;
        }

        public async Task<GetPublisherDTO> GetById(int id)
        {
            Publisher publisher = await _context.Publishers
                .FirstOrDefaultAsync(p => p.Id == id)
                ?? throw new ArgumentException($"No publisher with id: {id}");
            var bookDTOs = await GetBookPublisherDTOs(publisher);
            GetPublisherDTO dto = new()
            {
                Name = publisher.Name,
                Books = bookDTOs
            };
            return dto;
        }
    }
}
