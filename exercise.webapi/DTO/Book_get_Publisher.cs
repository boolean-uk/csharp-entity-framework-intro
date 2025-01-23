using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class Book_get_Publisher
    {
        public Book_get_Publisher(Publisher publisher)
        {
            this.Id = publisher.Id;
            this.Name = publisher.Name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        
    }
}
