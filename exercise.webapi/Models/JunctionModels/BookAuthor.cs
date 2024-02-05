using exercise.webapi.Models.DatabaseModels;

namespace exercise.webapi.Models.JunctionModels
{ // resource: https://learn.microsoft.com/en-us/ef/core/modeling/relationships/many-to-many
    public class BookAuthor
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
