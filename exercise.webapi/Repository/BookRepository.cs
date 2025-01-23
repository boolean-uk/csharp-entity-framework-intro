﻿using exercise.webapi.Data;
using exercise.webapi.Models;
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

        public async Task<Book> RemoveAuthor(int id)
        {
            Book target = await _db.Books.Include(a => a.Author).FirstOrDefaultAsync(b => b.Id == id);

            target.Author = null;
            target.AuthorId = 0;
            await _db.SaveChangesAsync();

            return target;
        }

        public async Task<Book> CreateBook(Book book)
        {
            
            await _db.Books.AddAsync(book);

            await _db.SaveChangesAsync();
            return book;
        }

        public async Task DeleteBook(int id)
        {
            Book book = await _db.Books.FindAsync(id);
            _db.Books.Remove(book);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();
        }

        public async Task<Book> GetBook(int id)
        {
            Book book = await _db.Books.Include(a => a.Author).FirstOrDefaultAsync(b => b.Id == id);

            if (book == null)
            {
                book = await _db.Books.FirstOrDefaultAsync(b => b.Id == id); 
            }
            return book;
        }

        public async Task<Book> UpdateBook(int id, Author newAuthor)
        {
            Book book = await _db.Books.Include(a => a.Author).FirstOrDefaultAsync(b => b.Id == id);

            if (book == null)
            {
                book = await _db.Books.FirstOrDefaultAsync(b => b.Id == id);
            }
            book.Author = newAuthor;

            await _db.SaveChangesAsync();
               
            return book;
        }
    }
}
