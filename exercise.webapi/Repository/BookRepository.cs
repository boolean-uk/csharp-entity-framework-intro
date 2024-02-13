using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.Models.DTO;
using exercise.webapi.Models.DTO_fromClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Validations;
using System.Diagnostics;

namespace exercise.webapi.Repository
{
    public class BookRepository: IBookRepository
    {
        DataContext _db;
        
        public BookRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<List<Book>> GetAllBooks()
        {
            /*
             var book_DTO = await (from booke in _db.Books
                                  join author in _db.Authors on booke.AuthorId equals author.Id
                                  select Converter.convertToBookDTO(booke, author)).ToListAsync();
             */
            //return await _db.Books.Include(b => b.Author).ToListAsync();
            var books = await this._db.Books.Include(b => b.Author).Include(b => b.Publisher).ToListAsync();
            return books;                                         
        }

        public async Task<Book_DTO_3> GetABook(int id) 
        {  
            var item = await _db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstAsync(b => b.Id == id);
            Book_DTO_3 book = new Book_DTO_3
            {
                Id = item.Id,
                AuthorId = item.AuthorId,
                Title = item.Title,
                Author = new AuthorDTO() 
                {
                    Id= item.AuthorId,
                    FirstName = item.Author.FirstName,
                    LastName = item.Author.LastName,
                    Email = item.Author.Email
                },
                Publisher = item.Publisher
            };
            return book;
        }

        public async Task<Book_DTO_3> UpdateBook(int book, int author) 
        {
            Book item = await this._db.Books.Include(b => b.Author).FirstAsync(b => b.Id == book);            
            item.AuthorId = author;
            await this._db.SaveChangesAsync();
            return await this.GetABook(book);
        }

        public async Task<Book> Delete(int id) 
        {
            Book book = await this._db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstAsync(b => b.Id == id);
            this._db.Books.Remove(book);
            await this._db.SaveChangesAsync();
            return book;
        }

        public async Task<Response<Book>> Create(Book_client_DTO client_dto) 
        {            
            Author? author = await this._db.Authors.FirstOrDefaultAsync(a => a.Id == client_dto.AuthorId);
            Publisher? publisher = await this._db.Publishers.FirstOrDefaultAsync(a => a.Id == client_dto.PublisherId);
            if (author == null || publisher == null) 
            {
                Response<Book> errorResponse = new Response<Book>()
                {
                    Status = System.Net.HttpStatusCode.NotFound,
                    item = new Book()
                };
                return errorResponse;
            }
            Book book = new Book()
            {
                Title = client_dto.Title,
                AuthorId = author.Id,
                Author = author,
                PublisherId = client_dto.PublisherId,
                Publisher = publisher
            };

            await this._db.Books.AddAsync(book);
            await this._db.SaveChangesAsync();
            //BookDTO bookDTO = Converter.convertToBookDTO(book, author);
            Response<Book> successResponse = new Models.Response<Book>()
            { 
                Status = System.Net.HttpStatusCode.Created,
                item = book
            };
            return successResponse;
        }
    }
}
