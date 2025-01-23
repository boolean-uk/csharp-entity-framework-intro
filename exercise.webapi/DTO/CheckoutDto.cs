using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class CheckoutDto
    {
        public BookDto Book { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime DueDate { get; set; }

        public CheckoutDto(Checkout checkout)
        {
            Book = new BookDto(checkout.Book);
            CheckoutDate = checkout.CheckoutDate;
            DueDate = checkout.DueDate;
        }
    }
}
