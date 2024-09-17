using exercise.webapi.Models;
using exercise.webapi.Models.DTO;
using System.Collections.Generic;

namespace exercise.webapi.Services
{
    public class DtoManager
    {
        // Convert from book to outputBook
        public static OutputBook Convert(Book book)
        {
            return new OutputBook
            {
                Id = book.Id,
                Title = book.Title,

                Author = new ExternalAuthor
                {
                    Id = book.AuthorId,
                    FirstName = book.Author.FirstName,
                    LastName = book.Author.LastName,
                    Email = book.Author.Email
                },

                Publisher = new ExternalPublisher
                {
                    Id = book.PublisherId,
                    Name = book.Publisher.Name
                }
            };
        }

        // Convert from book to OutputBook which does not contain author
        public static OutputBookWithoutAuthor ConvertWithoutAuthor(Book externalBook)
        {
            return new OutputBookWithoutAuthor
            {
                Id = externalBook.Id,
                Title = externalBook.Title,

                Publisher = new ExternalPublisher
                {
                    Id = externalBook.PublisherId,
                    Name = externalBook.Publisher.Name
                }
            };
        }

        // Convert from books to outputBooks which do not contain author
        public static IEnumerable<OutputBookWithoutAuthor> ConvertWithoutAuthor(IEnumerable<Book> books)
        {
            List<OutputBookWithoutAuthor> outputBooks = new List<OutputBookWithoutAuthor>();

            foreach (var book in books)
            {
                outputBooks.Add(ConvertWithoutAuthor(book));
            }

            return outputBooks;
        }

        // Convert from books to outputBooks
        public static IEnumerable<OutputBook> Convert(IEnumerable<Book> books)
        {
            List<OutputBook> outputBooks = new List<OutputBook>();

            foreach (var book in books)
            {
                outputBooks.Add(Convert(book));
            }

            return outputBooks;
        }

        // Convert from author to OutputAuthor
        public static OutputAuthor Convert(Author author)
        {
            return new OutputAuthor
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = ConvertWithoutAuthor(author.Books)
            };
        }

        // Convert from authors to outputAuthors
        public static IEnumerable<OutputAuthor> Convert(IEnumerable<Author> authors)
        {
            List<OutputAuthor> outputAuthors = new List<OutputAuthor>();

            foreach (var author in authors)
            {
                outputAuthors.Add(Convert(author));
            }

            return outputAuthors;
        }

        // Convert from publisher to OutputPublisher
        public static OutputPublisher Convert(Publisher publisher)
        {
            return new OutputPublisher
            {
                Id = publisher.Id,
                Name = publisher.Name,
                Books = Convert(publisher.Books)
            };
        }
        
        // Convert from publishers to outputPublishers
        public static IEnumerable<OutputPublisher> Convert(IEnumerable<Publisher> publishers)
        {
            List<OutputPublisher> outputPublishers = new List<OutputPublisher>();

            foreach (var publisher in publishers)
            {
                outputPublishers.Add(Convert(publisher));
            }

            return outputPublishers;
        }
    }
}
