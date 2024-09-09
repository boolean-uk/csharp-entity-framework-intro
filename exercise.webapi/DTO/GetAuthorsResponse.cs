namespace exercise.webapi.DTO
{
    public class GetAuthorsResponse
    {
        public List<DTOAuthorApi> Authors { get; set; } = new List<DTOAuthorApi>();
    }
}
