using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.Services;
using System.Runtime.InteropServices;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {

        public static void ConfigurePublisherApi(this WebApplication app)
        {
            app.MapGet("/publishers", GetPublishers);
            app.MapGet("/publishers/{id}", GetPublisher);
        }

        private static async Task<IResult> GetPublishers(PublisherService publisherService)
        {
            var books = await publisherService.GetPublishers();
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> GetPublisher(PublisherService publisherService, int id)
        {
            GetPublisherDTO publisher = null;

            try
            {
                publisher = await publisherService.GetPublisher(id);
            }
            catch (Exception ex)
            {
                return TypedResults.NotFound(ex.Message);
            }

            return TypedResults.Ok(publisher);
        }

    }
}
