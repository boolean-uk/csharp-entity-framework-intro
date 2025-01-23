namespace exercise.webapi.Models
{
    public class Checkout
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public DateTime CheckoutDate { get; set; }
        public bool IsReturned { get; set; }
        public DateTime DueDate { get; set; }
        public Book Book { get; set; }

    }
  
}
