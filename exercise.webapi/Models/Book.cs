using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        public List<Author> Authors { get; set; } = [];
        public List<AuthorBook> AuthorBooks { get; set; } = [];

        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public List<Checkout> Checkouts { get; set; }
    }
}
