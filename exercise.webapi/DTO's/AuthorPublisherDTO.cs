namespace exercise.webapi.DTO_s
{
    public class AuthorPublisherDTO
    {
        public int Id { get; internal set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<BookPublisherDto>  Books { get; set; } = new List<BookPublisherDto>();
    }
}
