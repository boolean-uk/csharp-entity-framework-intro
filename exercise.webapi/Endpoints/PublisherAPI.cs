using exercise.webapi.Models;
using exercise.webapi.Models.DTO;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class PublisherAPI
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            app.MapGet("/publisher", GetAll);            
            app.MapGet("/publisher/{id}", Get);            
        }

        public static async Task<IResult> GetAll(IPublisherRepository repository)
        {
            List<Publisher> publishers = await repository.GetAll();            
            return TypedResults.Ok(publishers);
        }
        public static async Task<IResult> Get(IPublisherRepository repository, int id)
        {
            Publisher_DTO publisher = await repository.Get(id);
            return TypedResults.Ok(publisher);
        }
    }
}
