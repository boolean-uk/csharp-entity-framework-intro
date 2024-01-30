using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class BookAuthor
    {

        public int AuthorId { get; set; }
        public Author Author { get; set; }


        public int BookId { get; set; }
        public Book Book { get; set; } 

    }
}
