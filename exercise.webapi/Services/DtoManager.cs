using exercise.webapi.Models;
using exercise.webapi.Models.DTO;
using System.Collections.Generic;

namespace exercise.webapi.Services
{
    public class DtoManager
    {
        
        public static OutputBook Convert(Book externalBook)
        {
            return new OutputBook
            {
                Id = externalBook.Id,
                Title = externalBook.Title,
                AuthorId = externalBook.AuthorId,
                Author = new ExternalAuthor
                {
                    FirstName = externalBook.Author.FirstName,
                    LastName = externalBook.Author.LastName,
                    Email = externalBook.Author.Email
                }
            };
        }
        public static IEnumerable<OutputBook> Convert(IEnumerable<Book> books)
        {
            List<OutputBook> outputBooks = new List<OutputBook>();

            foreach (var book in books)
            {
                outputBooks.Add(Convert(book));
            }

            return outputBooks;
        }

        public static OutputAuthor Convert(Author externalAuthor)
        {
            return new OutputAuthor
            {
                Id = externalAuthor.Id,
                FirstName = externalAuthor.FirstName,
                LastName = externalAuthor.LastName,
                Email = externalAuthor.Email,
                Books = Convert(externalAuthor.Books)
            };
        }

        public static IEnumerable<OutputAuthor> Convert(IEnumerable<Author> authors)
        {
            List<OutputAuthor> outputAuthors = new List<OutputAuthor>();

            foreach (var author in authors)
            {
                outputAuthors.Add(Convert(author));
            }

            return outputAuthors;
        }
    }
}
