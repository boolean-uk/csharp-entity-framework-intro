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

        public static IEnumerable<OutputBook> Convert(IEnumerable<Book> externalBooks)
        {
            List<OutputBook> outputBooks = new List<OutputBook>();

            foreach (var book in externalBooks)
            {
                outputBooks.Add(Convert(book));
            }

            return outputBooks;
        }
    }
}
