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

        public async Task<List<GetAuthorDTO>> GetAuthors()
        {
            var authors = await _authorRepository.GetAuthors();
            List<GetAuthorDTO> authorsDTO = new List<GetAuthorDTO>();

            foreach (var author in authors)
            {
                GetAuthorDTO authorDTO = ConvertToGetAuthorDTO(author);
                authorsDTO.Add(authorDTO);
            }

            return authorsDTO;
        }

        public async Task<GetAuthorDTO> GetAuthor(int id)
        {
            Author author = await _authorRepository.GetAuthor(id);

            GetAuthorDTO authorDTO = ConvertToGetAuthorDTO(author);

            return authorDTO;
        }

        private GetAuthorDTO ConvertToGetAuthorDTO(Author author)
        {

            var authorDTO = new GetAuthorDTO
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = author.Books.Select(b => new GetAuthorBookDTO
                {
                    Id = b.Id,
                    Title = b.Title
                }).ToList()
            };

            return authorDTO;
        }
    }
}
