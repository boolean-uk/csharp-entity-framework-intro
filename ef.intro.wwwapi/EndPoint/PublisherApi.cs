using ef.intro.wwwapi.Models;
using ef.intro.wwwapi.Repository;

namespace ef.intro.wwwapi.EndPoint
{
    public static class PublisherApi
    {
        public static void ConfigurePublishersApi(this WebApplication app)
        {
            app.MapGet("/publishers", GetPublishers);
            app.MapGet("/publishers/{id}", GetPublisher);
            app.MapPost("/publishers", InsertPublisher);
            app.MapPut("/publishers", UpdatePublisher);
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
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetPublisher(int id, ILibraryRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    var publisher = service.GetPublisher(id);
                    if (publisher == null) return Results.NotFound();
                    return Results.Ok(publisher);
                });

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> InsertPublisher(Publisher publisher, ILibraryRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    if (service.AddPublisher(publisher))
                        return Results.Ok();
                    return Results.NotFound();
                });

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> UpdatePublisher(Publisher publisher, ILibraryRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    if (service.UpdatePublisher(publisher))
                        return Results.Ok();
                    return Results.NotFound();
                });

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
