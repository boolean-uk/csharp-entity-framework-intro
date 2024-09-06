using System.Reflection.Metadata.Ecma335;
using exercise.webapi.Models;

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


    }
}
