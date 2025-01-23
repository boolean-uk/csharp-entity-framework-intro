using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
       Task<IEnumerable<Book>> GetAllBooks();

       Task <Book> GetBook(int id); 

       Task <Book> DeleteBook(int id);

       Task<Book> AddBook(Book book);
       Task<Book> UpdateBookById(int id, int targetid);

       


        
    }
}
