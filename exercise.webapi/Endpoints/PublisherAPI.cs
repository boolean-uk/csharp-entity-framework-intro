using exercise.webapi.Models.BaseModels;
using exercise.webapi.Models.DataTransfer.Publisher;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class PublisherAPI
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            var group = app.MapGroup("publishers");
            group.MapGet("/", GetAll);
            group.MapGet("/{id}", Get);
        }


        public static async Task<IResult> Get(IRepository<Publisher> publisherRepository, int id)
        {
            var publisher = await publisherRepository.Get(id);
            return TypedResults.Ok(new PublisherWithBooksDTO(publisher));
        }

        public static async Task<IResult> GetAll(IRepository<Publisher> publisherRepository)
        {
            var publishers = await publisherRepository.GetAll();
            List<PublisherWithBooksDTO> results = new List<PublisherWithBooksDTO>();
            foreach (var publisher in publishers)
            {
                results.Add(new PublisherWithBooksDTO(publisher));
            }
            return TypedResults.Ok(results);
        }
    }
}
