using exercise.webapi.Repository;
using exercise.webapi.DTO;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    
     public static class PublisherApi
        {
            public static void ConfigurePublisherApi(this WebApplication app)
            {
                app.MapGet("/publishers", GetPublishers);
                app.MapGet("/publishers/{id}", GetPublisherById);
            }
    
            private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
            {
                var publishers = await publisherRepository.GetAllPublishers();
                return TypedResults.Ok(PublisherResponseDTO.FromRepository(publishers));
            }
    
            private static async Task<IResult> GetPublisherById(IPublisherRepository publisherRepository, int id)
            {
                var publisher = await publisherRepository.GetPublisherById(id);
                if (publisher == null)
                {
                    return Results.NotFound();
                }
                return TypedResults.Ok(new PublisherResponseDTO(publisher));
            }
    
        }
}