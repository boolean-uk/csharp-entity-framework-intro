using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app) {
            app.MapGet("/publishers", GetPublishers);
            app.MapGet("/publishers/{id}", GetPublisher);
        }

        private static async Task<IResult> GetPublishers(IBookRepository bookRepository)
        {
            var publishers = new Payload<List<PublisherDTO>>()
            {
                Data = new List<PublisherDTO>()
            };

            var results = await bookRepository.GetAllPublishers();
            var books = await bookRepository.GetAllBooks();
            foreach (Publisher publisher in results)
            {
                PublisherDTO publisherDTO = new PublisherDTO();

                publisherDTO.FirstName = publisher.FirstName;
                publisherDTO.LastName = publisher.LastName;
               
                publisherDTO.Id = publisher.Id;
                publisherDTO.Books = new List<BookDTONoPublisher>();


                var publisherBooks = books.Where(b => b.PublisherId == publisher.Id).ToList();

                foreach (Book book in publisherBooks)
                {
                    AuthorDTOnoBooks dtoAuthor = new AuthorDTOnoBooks();
                    dtoAuthor.id = book.Author.Id;
                    dtoAuthor.FirstName = book.Author.FirstName;
                    dtoAuthor.LastName = book.Author.LastName;
                    dtoAuthor.Email = book.Author.Email;
                    BookDTONoPublisher dto = new BookDTONoPublisher();
                    dto.title = book.Title;
                    dto.author = dtoAuthor;
                    dto.id = book.Id;
                    
                    

                    publisherDTO.Books.Add(dto);
                }

                publishers.Data.Add(publisherDTO);
            }
            return TypedResults.Ok(publishers);
        }

        private static async Task<IResult> GetPublisher(IBookRepository bookRepository ,int id)
        {
            var payload = new Payload<PublisherDTO>();

            Publisher publisher = await bookRepository.GetPublisher(id);
            var books = await bookRepository.GetAllBooks();
            PublisherDTO publisherDTO = new PublisherDTO();
            
            publisherDTO.FirstName = publisher.FirstName;
            publisherDTO.LastName = publisher.LastName;
            publisherDTO.Id = publisher.Id;
            publisherDTO.Books = new List<BookDTONoPublisher>();
            var publisherBooks = books.Where(x => x.Publisher.Id == publisher.Id).ToList();
            foreach (Book book in publisherBooks)
            {
                AuthorDTOnoBooks authorDTO = new AuthorDTOnoBooks();
                authorDTO.FirstName = book.Author.FirstName;
                authorDTO.id = book.Author.Id;
                authorDTO.LastName = book.Author.LastName;
                authorDTO.Email = book.Author.Email;
                BookDTONoPublisher dto = new BookDTONoPublisher();
                dto.title = book.Title;
                dto.id = book.Id;
                dto.author = authorDTO;
                publisherDTO.Books.Add(dto);
            }

            payload.Data = publisherDTO;

            return TypedResults.Ok(payload);

        }


    }
}
