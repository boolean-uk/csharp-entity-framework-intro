using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class Checkout
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public DateTime CheckoutTime { get; set; } = DateTime.UtcNow;
        public DateTime? ReturnTime { get; set; }

        [NotMapped]
        public DateTime ExpectedReturnTime { get { return CheckoutTime.AddDays(14); } }
    }
}
