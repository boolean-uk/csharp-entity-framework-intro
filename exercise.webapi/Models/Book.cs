using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    [Table("books")]
    public class Book
    {
        [Column("book_id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("fk_author_id")]
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        [Column("fk_publisher_id")]
        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }

    public class BookDto
    {
        public string Title { get; set; }
        public AuthorInBookDto Author { get; set; }
        public PublisherInBookDto Publisher { get; set; }
        public BookDto(Book book)
        {
             Title = book.Title;
            Author = new AuthorInBookDto(book.Author);
            Publisher = new PublisherInBookDto(book.Publisher);
        }
    }

    public class BookUpdateDto
    {
        public string Title { get; set; }
        public int AuthorId { get; set; } 
        public AuthorInBookDto Author { get; set; }
        public PublisherInBookDto Publisher { get; set; }
        public BookUpdateDto(Book book)
        {
            Title = book.Title;
            AuthorId = book.AuthorId;
            Author = new AuthorInBookDto(book.Author);
            Publisher = new PublisherInBookDto(book.Publisher);
        }
    }

    public class BookCreateDto
    {
        public string Title { get; set; } 
        public BookCreateDto(string title)
        {
            Title = title;
        }
    }

    public class BookInAuthorDto
    {
        public string Title { get; set; }
        public PublisherInBookDto Publisher { get; set; }
        public BookInAuthorDto(Book book)
        {
            Title = book.Title;
            Publisher = new PublisherInBookDto(book.Publisher);
        }
    }
    public class BookInPublisherDto
    {
        public string Title { get; set; }
        public AuthorInBookDto Author { get; set; }
        public BookInPublisherDto(Book book)
        {
            Title = book.Title;
            Author = new AuthorInBookDto(book.Author);
        }
    }
}
