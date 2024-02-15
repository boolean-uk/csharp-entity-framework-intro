using exercise.webapi.Data;
using exercise.webapi.Models;
using static exercise.webapi.Repository.IAuthorRepository;
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

        
            public async Task<IEnumerable<Author>> GetAuthors()
            {
                return await _db.Authors.Include(a => a.BookAuthors).ThenInclude(b => b.Book).ToListAsync();
            }

            public async Task<Author?> GetAuthor(int authorId)
            {
                return await _db.Authors.Include(a => a.BookAuthors).ThenInclude(b => b.Book).FirstOrDefaultAsync(a => a.Id == authorId);
            }



            public async Task<Author?> DeleteAuthor(int authorID)
            {
                Author author = await GetAuthor(authorID);
                if (author != null)
                {
                    _db.Authors.Remove(author);
                    await _db.SaveChangesAsync();
                    return author;
                }

            return null;
            }

            public async Task<Author?> CreateAuthor(string FirstName, string LastName, string Email)
            {
                if (FirstName == ""||LastName == ""||Email=="") return null;
                Author author = new Author { FirstName = FirstName, LastName = LastName, Email = Email };
                await _db.Authors.AddAsync(author);
                await _db.SaveChangesAsync();
                return author;
            }




            public async Task<Author?> UpdateAuthor(int authorId, string newFirstName, string newLastName, string newEmail )
            {
                Author author = await GetAuthor(authorId);
                if (author != null)
                {
                    author.FirstName = newFirstName ?? author.FirstName;
                    author.LastName = newLastName ?? author.LastName;
                    author.Email = newEmail ?? author.Email;
                    await _db.SaveChangesAsync();

                    return author;
                }

                return null;
            }



        }
}



  

