using ef.intro.wwwapi.Models;
using ef.intro.wwwapi.Repository;

namespace ef.intro.wwwapi.EndPoint
{
    public static class PublisherApi
    {
        public static void ConfigurePublishersApi(this WebApplication app)
        {
            app.MapGet("/publishers", GetPublishers);
            //app.MapGet("/publishers/{id}", GetPublisher);
            //app.MapPost("/publishers", InsertPublisher);
            //app.MapPut("/publishers", UpdatePublisher);
            //app.MapDelete("/publishers", DeletePublisher);
        }

        private static async Task<IResult> GetPublishers(ILibraryRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    return Results.Ok(service.GetAllPublishers());
                });

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
