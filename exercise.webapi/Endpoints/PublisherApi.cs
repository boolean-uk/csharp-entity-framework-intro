using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;
using exercise.webapi.DTO;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Diagnostics;

namespace exercise.webapi.Endpoints
{

    [ApiController]
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            app.MapGet("/publisher", GetPublishers);
            app.MapGet("/publisher/{id}", GetPublisher);

            app.UseExceptionHandler(c => c.Run(async context =>
            {
                var exception = context.Features
                    .Get<IExceptionHandlerFeature>()
                    ?.Error;
                if (exception is not null)
                {
                    var response = new { error = exception.Message };
                    context.Response.StatusCode = 400;

                    await context.Response.WriteAsJsonAsync(response);
                }
            }));
        }

        private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository)
        {
            var publ = await publisherRepository.GetAllPublishers();
            return TypedResults.Ok(PublisherResponseDTO.FromRepository(publ));
        }

        private static async Task<IResult> GetPublisher(IPublisherRepository publisherRepository, int publId)
        {
            var publ = await publisherRepository.GetPublisher(publId);
           
            return TypedResults.Ok(new PublisherDTO(publ));
        }

        
    }
}
