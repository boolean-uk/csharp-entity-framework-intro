using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface ICheckoutRepository
    {
        public Task<IEnumerable<Checkout>> GetAllCheckouts();
        public Task<Checkout> GetCheckout(int id);
        public Task<Checkout> AddCheckout(Checkout checkout);
        public Task<bool> DeleteCheckout(int id);
        public Task<bool> UpdateCheckout(Checkout checkout);
        public Task<bool> IsCheckedOut(int bookId);

    }
}
