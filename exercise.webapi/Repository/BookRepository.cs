﻿using System.IO.Compression;
using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.AspNetCore.Components.Web;
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

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Authors).Include(b => b.Publisher).ToListAsync();
        }

        public async Task<Book?> GetABook(int bookId){
            return await _db.Books.Include(b => b.Authors).Include(b => b.Publisher).FirstOrDefaultAsync(b => b.Id == bookId);
        }
        public async Task<Book?> CreateBook(string title, Author author, Publisher publisher){
        if (title.GetType() != typeof(string))
        {
            return null;
        }
        if (author is not Author)
        {
            return null;
        }
        Book book = new Book
        {
            Title = title,
            Authors = new List<Author>(),
            PublisherId = publisher.Id,
            Publisher = publisher,
        };
        book.Authors.Add(author);

        _db.Books.Add(book);
        await _db.SaveChangesAsync();

        return book;
        }
        public void SaveChanges(){
            _db.SaveChanges();
        }

        public async Task<Book?> DeleteBook(int bookid)
        {
            Book book = await GetABook(bookid);
            if (book == null)
            {
                return null;
            }
            _db.Books.Remove(book);
            SaveChanges();
            return book;
        }
    }
}
