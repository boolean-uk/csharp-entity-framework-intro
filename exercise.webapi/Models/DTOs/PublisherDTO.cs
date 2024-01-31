
namespace exercise.webapi.Models.DTOs {

    public class PublisherDTO
    {
        public int Id { get; set; }
        public string Company { get; set; }

        public ICollection<BookWithoutPublisherDTO> Books { get; set; }

        public PublisherDTO(Publisher publisher)
        {
            Id = publisher.Id;
            Company = publisher.Company;
            Books = new List<BookWithoutPublisherDTO>();
            foreach (var bookAuthor in publisher.Books)
            {
            var bookWithAuthorDTO = new BookWithoutPublisherDTO(bookAuthor);

            Books.Add(bookWithAuthorDTO);
            }
        }

        public static List<PublisherDTO> FromRepository(IEnumerable<Publisher> publisher) {
             var results = new List<PublisherDTO>();
            foreach (var pub in publisher)
            {
                results.Add(new PublisherDTO(pub));

            }
            return results;
        }
    }
}
