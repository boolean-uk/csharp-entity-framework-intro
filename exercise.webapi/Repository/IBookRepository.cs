using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book?> GetBookById(int id);
        public Task<Book?> DeleteBookById(int id);
        public Task<Book?> AddBook(BookPostPayload payload, int authorId);
        public void SaveChanges();

    }
}
