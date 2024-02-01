﻿using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<BookDTO>> GetAllBooks();
        public Task<BookDTO> GetBookById(int id);

        public Task<Book> UpdateBook(int id, int authorId);

        public Task<BookDTO> DeleteBook(int id);

        public Task<Book> CreateBook(BookDTO book);
    }
}
