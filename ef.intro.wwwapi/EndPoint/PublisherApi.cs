using ef.intro.wwwapi.Models;
using ef.intro.wwwapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ef.intro.wwwapi.EndPoint
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            app.MapPost("/publishers", AddPublisher);
            app.MapGet("/publishers", GetPublishers);
            app.MapGet("/publishers/{id}", GetPublisher);
            app.MapPut("/publishers/{id}", UpdatePublisher);
            app.MapDelete("/publishers/{id}", DeletePublisher);
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
                    var person = service.GetPublisher(id);
                    if (person == null) return Results.NotFound();
                    return Results.Ok(person);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> AddPublisher(Publisher publisher, ILibraryRepository service)
        {
            try
            {
                if (service.AddPublisher(publisher)) return Results.Ok(publisher);
                return Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> UpdatePublisher(Publisher publisher, ILibraryRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    if (service.UpdatePublisher(publisher)) return Results.Ok(publisher);
                    return Results.NotFound();
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> DeletePublisher(int id, ILibraryRepository service)
        {
            try
            {
                if (service.DeletePublisher(id)) return Results.Ok();
                return Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
