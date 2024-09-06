using System.Reflection.Metadata.Ecma335;
using exercise.webapi.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.DTO
{
    public static class ConvertToDTOList
    {

        public static IEnumerable<DTOBook> ConvertToBOOKDTOList(this IEnumerable<Book> books)
        {

            return books.Select(b => new DTOBook
            {
                Title = b.Title,
                Author = b.Author.ConvertToAuthorDTO()
            });
        }

        public static DTOBook ConvertToBOOKDT(this Book b) 
        {
            if (b is null)
            {
                return null;
            }
            return new DTOBook { 
                Title = b.Title, 
                Author =b.Author.ConvertToAuthorDTO()
            };
        }


        public static DTOAuthor ConvertToAuthorDTO(this Author a)
        {
            if (a is null)
            {
                return null;
            }
            return new DTOAuthor
            {
                FirstName = a.FirstName,
                LastName = a.LastName,
                Books = null
            };
        }

        internal static IEnumerable<DTOAuthor> ConvertAuthorDOTList(IEnumerable<Author> authors)
        {
            return authors.Select(a => ConvertAuthorDOT(a));
        }

        internal static DTOAuthor ConvertAuthorDOT(Author a)
        {
            if (a is null)
            {
                return null;
            }
            List<Book> books = new List<Book>();
            foreach (Book b in a.Books)
            {
                books.Add(new Book { Title = b.Title, Author = null, Id = 0, AuthorId = 0 });
            }

            return new DTOAuthor
            {
                FirstName = a.FirstName,
                LastName = a.LastName,
                Books = books
            };
        }
    }
}
