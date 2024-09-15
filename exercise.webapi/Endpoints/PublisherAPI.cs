using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class PublisherAPI
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            var authorGroup = app.MapGroup("/publisher");
            authorGroup.MapGet("/", GetPublishers);
            authorGroup.MapGet("/{id}", GetPublisher);
        }

        private static async Task<IResult> GetPublishers(IRepository repository)
        {
            var publishers = await repository.GetAllPublishers();
            List<PublisherDTO> publisherDTO = new List<PublisherDTO>();
            foreach (var publisher in publishers)
            {
                publisherDTO.Add(CreatePrublisherDTO(publisher));
            }
            return TypedResults.Ok(publisherDTO);
        }
        private static async Task<IResult> GetPublisher(IRepository repository, int id)
        {
            var publisher = await repository.GetPublisherById(id);
            
            return TypedResults.Ok(CreatePrublisherDTO(publisher));
        }
        private static PublisherDTO CreatePrublisherDTO(Publisher publisher)
        {
            PublisherDTO publisherDTO = new PublisherDTO();
            publisherDTO.Name = publisher.Name;
            foreach (var book in publisher.Books)
            {
                BookAuthorlessDTO bookDTO = new BookAuthorlessDTO();
                bookDTO.Title = book.Title;
                bookDTO.Id = book.Id;
                publisherDTO.Books.Add(bookDTO);
            }
            return publisherDTO;
        }
        
    }
}
