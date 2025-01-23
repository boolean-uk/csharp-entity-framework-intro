using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.ViewModel;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Repository
{
    public class BookRepository: IBookRepository
    {
        DataContext _db;
        
        public BookRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<BookDto>> GetAllBooks()
        {
         
            var books = await _db.Books.Include(b => b.Author).ToListAsync();
            List<BookDto> booksDto = new List<BookDto>();
            books.ForEach(book => booksDto.Add(new BookDto(book)));
            return booksDto;
        }
        public async Task<BookDto> GetBook(int id)
        {
            try
            {
                return new BookDto(await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(book => book.Id == id));
            }
            catch (Exception ex)
            {
                Results.BadRequest(ex);
            }
            return null;

        }
        public async Task<BookDto> Update(int bookid, int authorId )
        {
            var book = await _db.Books.FirstOrDefaultAsync(book => book.Id == bookid);
            try
            {
                book.Author = await _db.Authors.FirstOrDefaultAsync(author => author.Id == authorId);    
                if(book.Author != null)
                {
                    await _db.SaveChangesAsync();
                    return await GetBook(bookid);
                }
            }
            catch (Exception ex) { Results.BadRequest( ex); }
            return null;
        }
        public async Task<bool> Delete(int bookid)
        {
            try
            {
                var book = _db.Books.FirstOrDefault(book => book.Id == bookid);
                _db.Books.Remove(book);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) 
            {
            Results.BadRequest(ex.Message);
            }
            return false; 
        }
        //implement the CREATE book - it should return NotFound when author id is not valid and BadRequest when book object not valid
        public async Task<BookDto> CreateBook(string title, int authorid)
        {
            try
            {
                var book = new Book();
                book.Title = title;
                book.AuthorId = authorid;
                book.Author = _db.Authors.FirstOrDefault(author => author.Id == authorid);

                _db.Books.Add(book);
                await _db.SaveChangesAsync();
                return new BookDto(book);
            }
            catch(Exception e)
            {
                Results.BadRequest(e.Message);
            }
            return null;
        }
        public async Task<List<AuthorDto>> GetAllAuthors()
        {


            var authors = await _db.Authors.Include(b => b.Books).ToListAsync();
            var authorDtos = new List<AuthorDto>();
            foreach (var author in authors)
            {
                List<string> books = await findBooksByAuthor(author.Id);
                authorDtos.Add(new AuthorDto(author, books));
            }
            return  authorDtos;
        }
        public async Task<BookDto> GetAuthor(int id)
        {
            try
            {
                return new BookDto(await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(book => book.Id == id));
            }
            catch (Exception ex)
            {
                Results.BadRequest(ex);
            }
            return null;

        }
        public async Task<List<string>> findBooksByAuthor(int authorid)
        {
           var books = await _db.Books.Where( b => b.AuthorId == authorid).ToListAsync();
            List<string> bookTitles = new List<string>();
            books.ForEach(b => bookTitles.Add(b.Title));
            return bookTitles;
        }

    }
}
