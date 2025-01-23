using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int AuthorId { get; set; }
        public MinimalAuthorDTO Author { get; set; }
    }
    public class MinimalAuthorDTO
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

    }
}
