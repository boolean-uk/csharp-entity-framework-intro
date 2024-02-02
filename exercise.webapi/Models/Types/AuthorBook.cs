using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models.Types;

public class AuthorBook
{
    [Column("ppk_author_id")]
    public int AuthorId { get; set; }
    public Author Author { get; set; }
    [Column("ppk_book_id")]
    public int BookId { get; set; }
    public Book Book { get; set; }
}
