namespace exercise.webapi.DTO
{
    public class TestBookPayload
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int? AuthorId { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
    }
}
