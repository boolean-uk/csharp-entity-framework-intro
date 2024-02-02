using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace exercise.webapi.Models
{
    public class Book
    {
        public int Id { get; internal set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public Book Update(Author newAuthor)
        {
            AuthorId = newAuthor.Id;
            Author = newAuthor;
            return this;
        }

        public BookDto ToDto()
        {
            return new BookDto
            {
                Title = Title,
                AuthorId = AuthorId,
                Author = Author.ToDto()
            };
        }
    }

    public struct BookDto
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public AuthorDto Author { get; set; }
    }

    public struct BookParams
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
    }
}
