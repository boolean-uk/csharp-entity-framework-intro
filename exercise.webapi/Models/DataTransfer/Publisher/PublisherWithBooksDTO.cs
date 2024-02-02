using exercise.webapi.Models.DataTransfer.Book;

namespace exercise.webapi.Models.DataTransfer.Publisher
{
    public class PublisherWithBooksDTO
    {
        public PublisherWithBooksDTO(BaseModels.Publisher publisher)
        {
            this.ID = publisher.ID;
            this.Name = publisher.Name;
            foreach (var book in publisher.Books)
            {
                this.Books.Add(new BookDetailedDTO(book));
            }
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public List<BookDetailedDTO> Books { get; set; } = new List<BookDetailedDTO>();
    }
}
