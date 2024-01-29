using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublishersApi(this WebApplication app)
        {
            app.MapGet("/publishers" , GetPublishers);
            app.MapGet("/publishers/{id}" , GetPublisherById);
        }

        private static async Task<IResult> GetPublishers([FromServices] IBookRepository bookRepository)
        {
            var publishers = await bookRepository.GetAllPublishers();
            return TypedResults.Ok(publishers);
        }

        private static async Task<IResult> GetPublisherById([FromServices] IBookRepository bookRepository , int id)
        {
            var publisher = await bookRepository.GetPublisherById(id);
            if(publisher == null)
                return Results.NotFound();

            return TypedResults.Ok(publisher);
        }
    }

}
