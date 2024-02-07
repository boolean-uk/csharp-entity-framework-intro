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
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

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
                Author = Author.ToData(),
                PublisherId = PublisherId,
                Publisher = Publisher.ToData()
            };
        }

        public BookAuthorDto ToAuthorDto()
        {
            return new BookAuthorDto
            {
                Title = Title,
                AuthorId = AuthorId,
                Author = Author.ToData()
            };
        }

        public BookPublisherDto ToPublisherDto()
        {
            return new BookPublisherDto
            {
                Title = Title,
                PublisherId = PublisherId,
                Publisher = Publisher.ToData()
            };
        }
    }

    public struct BookDto
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public AuthorData Author { get; set; }
        public int PublisherId { get; set; }
        public PublisherData Publisher { get; set; }
    }

    public struct BookParams
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
    }

    public struct BookAuthorDto
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public AuthorData Author { get; set; } 
    }

    public struct BookPublisherDto
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public PublisherData Publisher { get; set; }
    }
}
