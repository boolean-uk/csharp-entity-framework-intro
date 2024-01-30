namespace exercise.webapi.Models
{
    public class PublisherResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<BookWithAuthor> Books { get; set; } = new List<BookWithAuthor>();
        public PublisherResponseDTO(Publisher publisher)
        {
            Id = publisher.Id;
            Name = publisher.Name;
            foreach (Book book in publisher.Books)
            {
                Books.Add(new BookWithAuthor(book));
            }
        }
    }
}
