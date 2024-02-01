using exercise.webapi.AlternativeModels;
using exercise.webapi.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Conversions
{
    public static class AuthorConversion
    {
        public static List<AAuthorDto> toAuthor(List<Author> authors)
        {
            List<AAuthorDto> result = new List<AAuthorDto>();

            foreach (var entity in authors)
                result.Add(toAuthor(entity));

            return result;
        }

        public static AAuthorDto toAuthor(Author author)
        {
            var authorDto = new AAuthorDto()
            {
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email, 
                Books = new List<AMBookDto>()
            };

            foreach (var entity in author.Books)
            {
                authorDto.Books.Add(new AMBookDto() 
                { 
                    Title =  entity.Title, 
                    Publisher = new PPublisherDto() { Name = entity.Publisher.Name, 
                                   ContactDetails = entity.Publisher.ContactDetails} 
                }
                );
            }

            return authorDto;
        }
    }
}
