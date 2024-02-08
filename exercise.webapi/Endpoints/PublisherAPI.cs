using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{

    public class PublisherResponseDTO
    {
        public int Id { get; set; }
        public string name { get; set; }
        
        public List<BookResponseDTO> books { get; set; } = new List<BookResponseDTO>();

        public PublisherResponseDTO(Publisher publisher) 
        {
            Id = publisher.Id;
            name = publisher.Name;
            
            //add DTO:s for all books related to this publisher
            foreach (var book in publisher.Books)
            {
                BookResponseDTO bookToReturn = new BookResponseDTO(book);
                books.Add(bookToReturn);
            }
        }

    }
    public static class PublisherAPI
    {
        public static void ConfigurePublishersApi(this WebApplication app)
        {
            app.MapGet("/getPublishers", GetPublishers);
            app.MapGet("/getPublisherID", GetPublisherByID);
        }

        private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            var publishers = await publisherRepository.GetAllPublishers();
            var results = new List<PublisherResponseDTO>();
            foreach (var publisher in publishers)
            {
                results.Add(new PublisherResponseDTO(publisher));
            }
            return TypedResults.Ok(results);
        }

        private static async Task<IResult> GetPublisherByID(IPublisherRepository publisherRepository, int id)
        {
            var publisher = await publisherRepository.GetPublisherByID(id);
            if (publisher != null)
            {
                PublisherResponseDTO publisherToReturn = new PublisherResponseDTO(publisher);
                return TypedResults.Ok(publisherToReturn);
            }
            return TypedResults.BadRequest("/bad request");
        }
    }
}
