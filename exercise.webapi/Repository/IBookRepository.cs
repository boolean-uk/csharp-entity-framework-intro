﻿using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();

        public Task<Book?> GetBookById(int id);

        public Task<Book> AddBook(string title, int authorId);

        public Task<Book?> UpdateBook(int id, int authorId);

        public Task<Book?> DeleteBook(int id);
        
    }
}
