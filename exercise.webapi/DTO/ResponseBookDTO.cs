using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class ResponseBookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<AuthorDTO> Authors { get; set; }  // Modified to handle multiple authors

        public ResponseBookDTO()
        {
            Authors = new List<AuthorDTO>();  // Initialize the list in the constructor
        }
    }
}
