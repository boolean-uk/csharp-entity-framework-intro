using exercise.webapi.AlternativeModels;
using exercise.webapi.Models;

namespace exercise.webapi.Conversions
{
    public static class PublisherConversion
    {
        public static List<APublisherDto> toPublisher(List<Publisher> publishers)
        {
            List<APublisherDto> result = new List<APublisherDto>();

            foreach (var entity in publishers)
                result.Add(toPublisher(entity));

            return result;
        }

        public static APublisherDto toPublisher(Publisher publisher)
        {
            var result = new APublisherDto()
            {
                Name = publisher.Name,
                ContactDetails = publisher.ContactDetails,
                Books = new List<PMBookDto>()
            };

            foreach ( var book in  publisher.Books )
            {
                PMBookDto bookDto = new PMBookDto()
                {
                    Title = book.Title,
                    Author = new PAuthorDto()
                    {
                        FirstName = book.Author.FirstName,
                        LastName = book.Author.LastName,
                        Email = book.Author.Email
                    }
                };
                result.Books.Add(bookDto);
            }

            return result;
        }
    }
}
