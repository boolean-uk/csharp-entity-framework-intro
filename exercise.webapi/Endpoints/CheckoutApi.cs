using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class CheckoutApi
    {
        public static void ConfigureCheckoutApi(this WebApplication app)
        {
            var checkout = app.MapGroup("checkout");
            checkout.MapPost("/{bookId}", Checkout);
            checkout.MapGet("/overdue", GetOverdueBooks);
        }

        private static async Task<IResult> Checkout(ICheckoutRepository checkoutRepository,IBookRepository bookRepository, int bookId)
        {
            bool checkedOut = await checkoutRepository.IsCheckedOut(bookId);
            if (checkedOut)
            {
                return TypedResults.Ok("Book is unavailable");
            }
            Book book = await bookRepository.GetBook(bookId);
            Checkout checkout = new Checkout
            {
                BookId = bookId,
                DueDate = DateTime.Now.AddDays(14),
                IsReturned = false,
                CheckoutDate = DateTime.Now,
                Book = book
            };
            await checkoutRepository.AddCheckout(checkout);
            return TypedResults.Ok(new CheckoutDto(checkout));
        }


        public static async Task<IResult> GetOverdueBooks(IBookRepository bookRepository, ICheckoutRepository checkoutRepository)
        {
            var checkouts = await checkoutRepository.GetAllCheckouts();
            var overdue = checkouts.Where(c => c.DueDate < DateTime.Now && !c.IsReturned).OrderBy(c => c.DueDate);
            var overdueBooks = overdue.Select(c => new OverdueDto
            {
                Book = new BookDto(c.Book),
                DueDate = c.DueDate,
                DaysOverdue = (DateTime.Now - c.DueDate).Days
            });
            return TypedResults.Ok(overdueBooks);
        }


    }
}
