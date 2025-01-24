
using exercise.webapi.DTO;
using exercise.webapi.Exceptions;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class CheckoutEndpoints
    {
        public static string Path { get; private set; } = "checkouts";

        public static void ConfigureCheckoutEndpoints(this WebApplication app)
        {
            var group = app.MapGroup(Path);

            group.MapGet("/", GetCheckouts);
            group.MapGet("/{id}", GetCheckout);
            group.MapPost("/checkout", CheckoutBook);
            group.MapPost("/return", ReturnBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> GetCheckouts(IRepository<Checkout> repository)
        {
            try
            {
                IEnumerable<Checkout> checkouts = await repository.GetAll();
                return TypedResults.Ok(checkouts.Select(checkout =>
                {
                    return new CheckoutView(
                        checkout.Id,
                        checkout.CheckoutTime,
                        checkout.ReturnTime,
                        checkout.ExpectedReturnTime,
                        new BookInternalAuthorPublisher(
                            checkout.Book.Id,
                            checkout.Book.Title,
                            checkout.Book.Authors.Select(author => new AuthorInternal(
                                author.Id,
                                author.FirstName,
                                author.LastName,
                                author.Email
                            )),
                            new PublisherInternal(
                                checkout.Book.Publisher.Id,
                                checkout.Book.Publisher.Name
                            )
                        )
                    );
                }));
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetCheckout(IRepository<Checkout> repository, int id)
        {
            try
            {
                Checkout checkout = await repository.Get(id);
                return TypedResults.Ok(new CheckoutView(
                        checkout.Id,
                        checkout.CheckoutTime,
                        checkout.ReturnTime,
                        checkout.ExpectedReturnTime,
                        new BookInternalAuthorPublisher(
                            checkout.Book.Id,
                            checkout.Book.Title,
                            checkout.Book.Authors.Select(author => new AuthorInternal(
                                author.Id,
                                author.FirstName,
                                author.LastName,
                                author.Email
                            )),
                            new PublisherInternal(
                                checkout.Book.Publisher.Id,
                                checkout.Book.Publisher.Name
                            )
                        )));
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new { ex.Message });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> CheckoutBook(IRepository<Checkout> checkoutRepository, IRepository<Book> bookRepository, CheckoutPost entity)
        {
            try
            {
                Book book = await bookRepository.Get(entity.BookId);
                if (book.Checkouts.Any(checkout => checkout.ReturnTime == null)) return TypedResults.Conflict(new { Message = "That book is already checked out!" });
                Checkout checkout = await checkoutRepository.Add(new Checkout
                {
                    BookId = book.Id,
                });
                return TypedResults.Created($"/{Path}/{checkout.Id}", new CheckoutView(
                        checkout.Id,
                        checkout.CheckoutTime,
                        checkout.ReturnTime,
                        checkout.ExpectedReturnTime,
                        new BookInternalAuthorPublisher(
                            checkout.Book.Id,
                            checkout.Book.Title,
                            checkout.Book.Authors.Select(author => new AuthorInternal(
                                author.Id,
                                author.FirstName,
                                author.LastName,
                                author.Email
                            )),
                            new PublisherInternal(
                                checkout.Book.Publisher.Id,
                                checkout.Book.Publisher.Name
                            )
                        )));
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new { ex.Message });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> ReturnBook(IRepository<Checkout> checkoutRepository, IRepository<Book> bookRepository, CheckoutPost entity)
        {
            try
            {
                Book book = await bookRepository.Get(entity.BookId);
                if (book.Checkouts.All(checkout => checkout.ReturnTime != null)) return TypedResults.Conflict(new { Message = "That book is not checked out!" });
                Checkout? checkout = book.Checkouts.Where(c => c.ReturnTime == null).FirstOrDefault();
                if (checkout == null)
                {
                    return TypedResults.Problem("This should never happen but okay...");
                }
                checkout.ReturnTime = DateTime.UtcNow;
                checkout = await checkoutRepository.Update(checkout);
                return TypedResults.Ok(new CheckoutView(
                        checkout.Id,
                        checkout.CheckoutTime,
                        checkout.ReturnTime,
                        checkout.ExpectedReturnTime,
                        new BookInternalAuthorPublisher(
                            checkout.Book.Id,
                            checkout.Book.Title,
                            checkout.Book.Authors.Select(author => new AuthorInternal(
                                author.Id,
                                author.FirstName,
                                author.LastName,
                                author.Email
                            )),
                            new PublisherInternal(
                                checkout.Book.Publisher.Id,
                                checkout.Book.Publisher.Name
                            )
                        )));
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new { ex.Message });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
