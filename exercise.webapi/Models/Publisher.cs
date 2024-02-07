namespace exercise.webapi.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();

        public PublisherDto ToDto()
        {
            return new PublisherDto
            {
                FirstName = FirstName,
                LastName = LastName,
                Email = Email,
                Books = Books.Select(b => b.ToAuthorDto()).ToList()
            };
        }

        public PublisherData ToData()
        {
            return new PublisherData
            {
                FirstName = FirstName,
                LastName = LastName,
                Email = Email
            };
        }
    }

    public struct PublisherDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<BookAuthorDto> Books { get; set; }
    }

    public struct PublisherData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
