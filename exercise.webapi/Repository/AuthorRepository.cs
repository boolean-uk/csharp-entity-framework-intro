using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        DataContext _db;
        public AuthorRepository(DataContext db)
        {
            this._db = db;
        }

        public async Task<List<Author_DTO_2>> getAll() 
        {
            var authors = this._db.Authors.Include(a => a.Books).ThenInclude(b => b.Publisher);
            List<Author_DTO_2> authorsRepsonse = authors.Select(x => new Author_DTO_2
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                Books = x.Books.Select(x => new Book_DTO_2 
                {
                    Id = x.Id,
                    Title = x.Title,
                    Publisher = x.Publisher,
                }).ToList()
                
            }).ToList();

            return authorsRepsonse;
        }
        
        public async Task<Author_DTO_2> getAuthor(int id) 
        {            
            var author = await this._db.Authors.Include(a => a.Books).ThenInclude(b => b.Publisher).SingleAsync(a => a.Id == id);
            Author_DTO_2 response = new Author_DTO_2
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = author.Books.Select(x => new Book_DTO_2
                {
                    Id = x.Id,
                    Title = x.Title,
                    Publisher = x.Publisher
                }).ToList()
            };                        

            return response;
        }
    }
}
