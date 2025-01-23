using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class Publisher_get
    {
        public Publisher_get(Publisher publisher)
        {
            this.Id = publisher.Id;
            this.Name = publisher.Name;
            this.books  = publisher.Books.Select(x => new Publisher_get_Book(x)).ToList();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Publisher_get_Book> books { get; set; }

    }
}
