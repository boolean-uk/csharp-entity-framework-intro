using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Text.Json.Serialization;


namespace exercise.webapi.Models
{
    public class Publisher
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }  
        public string LastName { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }

    public class PublisherDTO
    {
        private string _firstName;
        private string _lastName;
        private List<BookForPublisherDTO> _books = new List<BookForPublisherDTO>();

        public PublisherDTO(Publisher publisher) {

            _firstName = publisher.FirstName;
            _lastName = publisher.LastName;
            if (publisher.Books.Count > 0)
            {
                foreach (var book in publisher.Books)
                {
                    if (book != null && book.Author != null)
                    {
                        _books.Add(new BookForPublisherDTO()
                        {
                            Title = book.Title,
                            Author = new SimpleAuthorDTO
                            {
                                FirstName = book.Author.FirstName,
                                LastName = book.Author.LastName
                            }
                        });
                    }
                }
            }
        }
        public string FirstName { get { return _firstName; } }
        public string LastName { get { return _lastName; } }
        [JsonInclude]
        public List<BookForPublisherDTO> Books { get {  return _books; } }
    }
}
