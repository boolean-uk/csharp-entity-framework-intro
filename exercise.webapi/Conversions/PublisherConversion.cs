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
                    Authors = new List<PAuthorDto>()
                };
                foreach ( var author in book.Authors.Select(x => x.Author))
                {
                    bookDto.Authors.Add(new PAuthorDto()
                    {
                        FirstName = author.FirstName,
                        LastName = author.LastName,
                        Email = author.Email
                    });
                }
                result.Books.Add(bookDto);
            }

            return result;
        }
    }
}
