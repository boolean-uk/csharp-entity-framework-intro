using exercise.webapi.DTOs.BookApi;

namespace exercise.webapi.DTOs.AuthorApi
{
    public class GetAuthorsResponse
    {
        public List<AuthorDTO> Authors { get; set; } = new List<AuthorDTO>();
    }
}
