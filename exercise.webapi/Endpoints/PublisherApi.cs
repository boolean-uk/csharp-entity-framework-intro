using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class PublisherApi
    {
        public static void ConfigurePublisherApi(this WebApplication app)
        {
            var group = app.MapGroup("publishers");
            group.MapGet("/", GetPublishers);
            group.MapGet("/{id}", GetSinglePublisher);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetPublishers(IRepository Repository)
        {
            var publishers = await Repository.GetAllPublishers();
            var BookAuthors = await Repository.GetAllBookAuthors();
            ICollection<DTPublisher> tList = new List<DTPublisher>(); 

            foreach (Publisher publisher in publishers) { 

                 List<SimpleBook> books = new List<SimpleBook>();

                foreach (var book in publisher.Books)
                {
                    string authors = "";
                    foreach(var ba in BookAuthors)
                    {
                        if(ba.BookId == book.Id)
                        {
                            authors += $"{ba.Author.FirstName} {ba.Author.LastName}, ";
                        }
                    }

                    books.Add(
                        new SimpleBook(){
                        Id = book.Id,
                        Title = book.Title,
                        AuthorName = authors,
                        PublisherName = $"{book.Publisher.Firstname} {book.Publisher.Lastname}"
                    }
                    );
                }
                DTPublisher tpublisher = new DTPublisher() { Id = publisher.Id, Lastname = publisher.Lastname, Firstname = publisher.Firstname, BookCounter = books.Count, Books = books };
            
                tList.Add(tpublisher);
            }


            return TypedResults.Ok(tList);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetSinglePublisher(IRepository Repository, int id)
        {
            var publisher = await Repository.GetPublisherById(id);
            var BookAuthors = await Repository.GetAllBookAuthors();

            List<SimpleBook> books = new List<SimpleBook>();

            foreach (var book in publisher.Books) 
            {
                string authors = "";
                foreach (var ba in BookAuthors)
                {
                    if (ba.BookId == book.Id)
                    {
                        authors += $"{ba.Author.FirstName} {ba.Author.LastName}, ";
                    }
                }

                books.Add(new SimpleBook() { Id = book.Id, Title = book.Title, AuthorName = authors, PublisherName = $"{book.Publisher.Firstname} {book.Publisher.Lastname}"
                 });
                
            }
             DTPublisher tpublisher = new DTPublisher() {Id = publisher.Id, Lastname = publisher.Lastname, Firstname = publisher.Firstname , BookCounter = books.Count, Books = books};
            
            return TypedResults.Ok(tpublisher);
        }
            

    }

    
};
