﻿using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book> GetBookById(int id);
        public Task<Book> UpdateBook(int id,int NewAuthorId);
        public Task<Book> DeleteBook(int id);
        public Task<Book> CreateBook(InputBook book);
        public Task<Author> GetAuthorById(int id);
        public Task<IEnumerable<Author>> GetAllAuthors();
        public Task<Publisher> GetPublisherById(int id);
        public Task<IEnumerable<Publisher>> GetAllPublishers();

    }
}
