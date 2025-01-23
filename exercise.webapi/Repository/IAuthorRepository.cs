using System;
using exercise.webapi.DTO;
using exercise.webapi.Payload;

namespace exercise.webapi.Repository;

public interface IAuthorRepository
{
    public Task<Payload<IEnumerable<AuthorDTO>>> GetAuthors();
    public Task<Payload<AuthorDTO>> GetAuthor(int id);
}
