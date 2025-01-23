using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Payload;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class BookRepository: IBookRepository
    {
        DataContext _db;
        
        public BookRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<Payload<IEnumerable<BookDTO>>> GetAllBooks()
        {
            Payload<IEnumerable<BookDTO>> payload = new Payload<IEnumerable<BookDTO>>();
            List<Book> books = await _db.Books.Include(b => b.Author).Include(b => b.Publisher).ToListAsync();
            List<BookDTO> bookDTOs = new List<BookDTO>();
            foreach (Book b in books)
            {
                bookDTOs.Add(new BookDTO(b));
            }
            payload.Data = bookDTOs;
            return payload;
        }

        public async Task<Payload<BookDTO>> GetBook(int id)
        {
            Payload<BookDTO> payload = new Payload<BookDTO>();
            Book book = await _db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefaultAsync(b => b.Id == id);
            try
            {
                payload.Data = new BookDTO(book);
                return payload;
            }
            catch (Exception)
            {
                payload.GoodResponse = false;
                payload.Message = $"Could not find book with id={id}";
                return payload;
            }
        }

        public async Task<Payload<BookDTO>> UpdateAuthor(int bookId, AuthorPostDTO authorPost)
        {
            Payload<BookDTO> payload = new Payload<BookDTO>();
            Book book = await _db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefaultAsync(b => b.Id == bookId);
            if (book != null)
            {
                // Found book
                Author newAuthor = await _db.Authors.Include(a => a.Books).FirstOrDefaultAsync(a => a.Id == authorPost.Id);
                if (newAuthor != null)
                {
                    // Found book and the new author
                    Author oldAuthor = book.Author;
                    book.Author = newAuthor;

                    // Update the books of each of the authors
                    oldAuthor.Books.Remove(book);
                    newAuthor.Books.Add(book);

                    payload.Data = new BookDTO(book);
                    await _db.SaveChangesAsync();
                    return payload;

                }

                else
                {
                    //The new author not found
                    payload.GoodResponse = false;
                    payload.Message = $"Could not find author with id = {authorPost.Id}";
                    return payload;

                }
            }
            else 
            {
                // Book not found
                payload.GoodResponse = false;
                payload.Message = $"Could not find book with id = {bookId}";
                return payload;
            }
            
        }

        public async Task<Payload<BookDTO>> DeleteBook(int id)
        {
            Payload<BookDTO> payload = new Payload<BookDTO>();
            Book book = await _db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefaultAsync(b => b.Id == id);
            if (book != null)
            {
                Author author = book.Author;
                author.Books.Remove(book);
                _db.Books.Remove(book);
                payload.Data = new BookDTO(book);
                await _db.SaveChangesAsync();
                
                return payload;
            }

            payload.GoodResponse = false;
            payload.Message = $"Book with id={id} not found";

            return payload;
        }


        public async Task<Payload<BookDTO>> CreateBook(CreateBookDTO bookDTO)
        {
            Payload<BookDTO> payload = new Payload<BookDTO>();

            Author author = await _db.Authors.FindAsync(bookDTO.AuthorId);

            if (author != null)
            {
                Book book = new Book();
                book.Title = bookDTO.Title;
                book.AuthorId = bookDTO.AuthorId;
                book.Author = author;

                _db.Add(book);
                author.Books.Add(book);

                await _db.SaveChangesAsync();
                payload.Data = new BookDTO(book);
                return payload;
            }


            payload.GoodResponse = false;
            payload.Message = $"Author with id={bookDTO.AuthorId} not found!";

            return payload;


        }


    }
}
