using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class PublisherEndpoint
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            var group = app.MapGroup("publishers");

            app.MapGet("/publishers", GetPublishers);
            app.MapGet("/publishers/{publisherId}", GetBooksByPublisher);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetPublishers(IBookRepository bookRepository)
        {
            var publishers = await bookRepository.GetAllPublishers();
            return TypedResults.Ok(publishers);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetBooksByPublisher(IBookRepository bookRepository, int publisherId)
        {
            var publisher = await bookRepository.GetBooksByPublisherId(publisherId);
            if(publisher == null)
            {
                return TypedResults.NotFound("Publisher with provided id doesn't exists");
            }
            return TypedResults.Ok(publisher);
        }
    }
}
