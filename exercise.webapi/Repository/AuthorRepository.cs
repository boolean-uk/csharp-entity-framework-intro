using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        DataContext _db;

        public AuthorRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<ResponseAuthorDTO>> GetAll()
        {
            var authors = await _db.Authors
                .Include(a => a.BookAuthors) 
            .ThenInclude(ba => ba.Book) 
            .ToListAsync();
            List<ResponseAuthorDTO> result = new List<ResponseAuthorDTO>();
            foreach (var author in authors)
            {
                result.Add(PutAuthor(author));
            }
            _db.SaveChanges();
            return result;
        }

        public async Task<ResponseAuthorDTO> GetAuthor(int id)
        {
            var author = await _db.Authors
                .Include(a=>a.BookAuthors)
                .ThenInclude(ba=> ba.Book)
                .SingleOrDefaultAsync(a=>a.Id == id);
            ResponseAuthorDTO result = PutAuthor(author);
            _db.SaveChanges();
            return result;
        }

        private ResponseAuthorDTO PutAuthor(Author? author)
        {
            ResponseAuthorDTO response = new ResponseAuthorDTO();
            if(author != null)
            {
                response.FirstName = author.FirstName;
                response.LastName = author.LastName;
                response.Email = author.Email;
                response.Id = author.Id;
                foreach (var book in author.BookAuthors)
                {
                    BookDTO dto = new BookDTO();
                    dto.Id = book.BookId;
                    dto.Title = book.Book.Title;
                    response.Books.Add(dto);
                }
                return response;
            }
            throw new Exception("Something went wrong, author was null");
        }
    }
}
