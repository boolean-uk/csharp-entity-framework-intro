using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class AuthorRepository: IAuthorRepository
    {
        DataContext _db;
        
        public AuthorRepository(DataContext db)
        {
            _db = db;
        }


       
        public async Task<IEnumerable<AuthorResponseDTO>> GetAllAuthors()
        {
            
            var authors = await _db.Authors.Include(a => a.Books).ToListAsync();
            List<AuthorResponseDTO> result = new List<AuthorResponseDTO>();
            foreach (var author in authors)
            {
                result.Add(PutAuthorInDTO(author));
            }
            _db.SaveChanges();
            return result;
        }

        public async Task<AuthorResponseDTO> GetAuthor(int id)
        {
            
            var author = await _db.Authors.Include(a => a.Books).SingleOrDefaultAsync(a => a.Id == id);
            AuthorResponseDTO authorResponseDTO = PutAuthorInDTO(author);
            _db.SaveChanges();
            return authorResponseDTO;
        }
       

        private AuthorResponseDTO PutAuthorInDTO(Author? author)
        {
            AuthorResponseDTO responseDTO = new AuthorResponseDTO();
            if(author != null)
            {
                responseDTO.Id = author.Id;
                responseDTO.FirstName = author.FirstName;
                responseDTO.LastName = author.LastName;
                responseDTO.Email = author.Email;

                foreach(var book in author.Books)
                {
                    BookDTO bookDTO = new BookDTO();
                    bookDTO.Id = book.Id;
                    bookDTO.Title = book.Title;
                    responseDTO.Books.Add(bookDTO);
                }

                

                return responseDTO;
            }
            else
            {
                throw new Exception("Author was null");
            }

            
        }
       
       

    }
}
