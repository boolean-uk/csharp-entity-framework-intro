using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [ForeignKey("PublisherId")]
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public ICollection<AuthorBook> AuthorBooks { get; set; } = new List<AuthorBook>();
        // Removed Authors collection, as many-to-many relationships should be managed through the join table
    }
}