﻿using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();

        public Task<Book> GetBookById(int id);

        public Task<Book> UpdateBookById(int id, int newAuthorId);

        public Task<Book> DeleteBookById(int id);

        public Task<Book> CreateBook(Book book);



        public Task<IEnumerable<Author>> GetAllAuthors();
        public Task<Author> GetAuthorById(int id);


        
        public Task<Publisher> GetPublisherById(int id);

        public Task<IEnumerable<Publisher>> GetAllPublishers();
    }
}
