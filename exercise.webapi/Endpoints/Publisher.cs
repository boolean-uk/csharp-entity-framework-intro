namespace exercise.webapi.Endpoints

{
    using exercise.webapi.Models;
    using exercise.webapi.Models.DTO;
    using exercise.webapi.Repository;
    using Microsoft.AspNetCore.Mvc;
    using static System.Reflection.Metadata.BlobBuilder;
    public static class Publisher
    {

        public static void ConfigurePublisherApi(this WebApplication app)
        {
            app.MapGet("/GetPublishers", GetPublishers);
        }

        private static async Task<IResult> GetPublishers(IPublisherRepository publisherRepository, IAuthorRepository authorRepository)
        {
            var publishers = await publisherRepository.GetPublishers();

            var publisherDtos = new List<GetPublisherDto>();
            foreach (var publisher in publishers)
            {
                GetPublisherDto result = new GetPublisherDto()
                {
                    Name = publisher.Name,
                    Id = publisher.Id,
                    Books = new List<BookDto2>() // Initialize the Books list
                };

                foreach (Models.Book b in publisher.Books) 
                {
                    var author = await authorRepository.GetAuthorById(b.AuthorId); // Retrieve the author information
                    BookDto2 bookDto2 = new BookDto2()
                    {
                        Id = b.Id,
                        Title = b.Title,
                        Author = new AuthorDto2 // Create a DTO for the author
                        {
                            Id = author.Id,
                            firstName = author.FirstName,
                            lastName = author.LastName,
                            email = author.Email
                        }
                    };
                    result.Books.Add(bookDto2);
                }

                publisherDtos.Add(result);
            }

            return TypedResults.Ok(publisherDtos);
        }
    }

}
