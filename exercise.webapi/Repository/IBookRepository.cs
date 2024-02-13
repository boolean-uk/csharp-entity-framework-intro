using exercise.webapi.Models;
using exercise.webapi.Models.DTO;
using exercise.webapi.Models.DTO_fromClient;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllBooks();
        Task<Book_DTO_3> GetABook(int id);
        Task<Book_DTO_3> UpdateBook(int book, int author);
        Task<Book> Delete(int id);
        Task<Response<Book>> Create(Book_client_DTO client_dto);
    }
}
