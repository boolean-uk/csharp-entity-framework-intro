using exercise.webapi.Models.DataTransfer.Books;

namespace exercise.webapi.Models.DatabaseModels
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
