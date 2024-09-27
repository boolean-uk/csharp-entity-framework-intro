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
                Authors = new List<PAuthorDto>(),
                Publisher = new PPublisherDto() { Name = book.Publisher.Name,
                    ContactDetails = book.Publisher.ContactDetails }
            };

            foreach( var author in book.Authors.Select(x => x.Author))
            {
                var Author = new PAuthorDto()
                {
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    Email = author.Email
                };
                member.Authors.Add(Author);
                
            }

            return member;

        }

        public static Book toCreate(PostBook postBook)
        {

            Book book = new Book()
            {
                Title = postBook.Title, 
                PublisherId = postBook.PublisherId
            };

            return book;
        }
    }
}
