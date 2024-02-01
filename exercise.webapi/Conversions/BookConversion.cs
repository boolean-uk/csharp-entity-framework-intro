    using exercise.webapi.AlternativeModels;
using exercise.webapi.Models;

namespace exercise.webapi.Conversions
{
    public static class BookConversion
    {

        public static List<ABookDto> toBook(List<Book> books)
        {
            List<ABookDto> result = new List<ABookDto>();
            foreach (var entity in books)
            {
                result.Add(toBook(entity));
            }

            return result;
        }

        public static ABookDto toBook(Book book)
        {
            var member = new ABookDto()
            {
                Title = book.Title,
                Author = new PAuthorDto()
                {
                    FirstName = book.Author.FirstName,
                    LastName = book.Author.LastName,
                    Email = book.Author.Email
                },
                Publisher = new PPublisherDto() { Name = book.Publisher.Name,
                    ContactDetails = book.Publisher.ContactDetails }
            };

            return member;

        }

        public static Book toCreate(PostBook postBook)
        {

            Book book = new Book()
            {
                Title = postBook.Title,
                AuthorId = postBook.AuthorId, 
                PublisherId = postBook.PublisherId
            };

            return book;
        }
    }
}
