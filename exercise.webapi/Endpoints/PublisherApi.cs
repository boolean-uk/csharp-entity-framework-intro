using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            var group = app.MapGroup("/publishers");

            group.MapGet("/", GetAll);
        }

        private async static Task<IResult> GetAll(IPublisherRepository repository)
        {
            return TypedResults.Ok(await repository.GetAll());
        }
    }
}
