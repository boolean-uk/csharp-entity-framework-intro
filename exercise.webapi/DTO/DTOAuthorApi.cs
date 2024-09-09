namespace exercise.webapi.DTO
{
    public class DTOAuthorApi
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<DTOAuthorBook> books { get; set; } = new List<DTOAuthorBook>();

    }
}
