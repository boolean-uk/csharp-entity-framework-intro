using exercise.webapi.AlternativeModels;
using exercise.webapi.Models;

namespace exercise.webapi.Conversions
{
    public static class BookConversion
    {

        public static List<BBookDto> toBook(List<Book> books)
        {
            List<BBookDto> result = new List<BBookDto>();
            foreach (var entity in books)
            {
                result.Add(toBook(entity));
            }

            return result;
        }

        public static BBookDto toBook(Book book)
        {
            var member = new BBookDto()
            {
                Title = book.Title,
                Author = new BAuthorDto()
                {
                    FirstName = book.Author.FirstName,
                    LastName = book.Author.LastName,
                    Email = book.Author.Email
                }
            };

            return member;

        }
    }
}
