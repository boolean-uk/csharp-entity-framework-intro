using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace exercise.webapi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        //public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
    }
}

