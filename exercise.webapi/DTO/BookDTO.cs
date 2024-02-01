using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public struct BookDTO
    {
        public string Title { get; set; }
        public int ID { get; internal set; }
    }
    public struct BookDetailsDTO
    {
        public int Id { get; internal set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; internal set; }
    }
    public struct CreateBookDTO
    {
        public string Title { get; set; }
        public int AuthorID { get; set; }
    }
}
