using System.Reflection.Emit;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Services
{
    public class AuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository repository)
        {
            _authorRepository = repository;
        }

        public async Task<Author> GetAuthor(int id)
        {
            Author author = await _authorRepository.GetAuthor(id);

            return author;
        }
    }
}
