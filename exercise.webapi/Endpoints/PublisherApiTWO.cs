using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace exercise.webapi.Endpoints;

public static class PublisherApiTWO
{
    public static void ConfigurePublisherApi(this WebApplication app)
    {
        app.MapGet("/publishers{id}", GetPublisher);
        app.MapGet("/publishers/", GetPublishers);
    }

    private static async Task<IResult> GetPublisher(IPublisherRepository pubRepo, int id)
    {
        Publisher publisher = await pubRepo.GetPublisherById(id);
        return TypedResults.Ok(new
        {
            Id = publisher.Id,
            name = publisher.Name
        });
    }

    private static async Task<IResult> GetPublishers(IPublisherRepository pubRepo, IBookRepository bookRepo)
    {
        var publishers = await pubRepo.GetAllPublishers();
        List<Object> anonPubList = new List<Object>();


        foreach (Publisher pub in publishers)
        {
            
            pub.Books = bookRepo.GetAllBooks().Result.Where(a => a.PublisherId == pub.Id).ToList();

            List<string> books = new List<string>();

            foreach (Book book in pub.Books)
            {
                books.Add(book.Title);
            }


            anonPubList.Add(new
            {
                Id = pub.Id,
                Name = pub.Name,
                books = books

            });
        }

        return TypedResults.Ok(anonPubList);
    }
}
