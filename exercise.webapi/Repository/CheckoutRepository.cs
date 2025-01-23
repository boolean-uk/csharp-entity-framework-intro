using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class CheckoutRepository : ICheckoutRepository
    {
        DataContext _db;
        public CheckoutRepository(DataContext db)
        {
            _db = db;
        }


        public async Task<Checkout> GetCheckout(int id)
        {
            return await _db.Checkouts
                .Include(c => c.Book)
                    .ThenInclude(b => b.BookAuthors)
                        .ThenInclude(ba => ba.Author)
                .Include(c => c.Book)
                    .ThenInclude(b => b.Publisher)
                .FirstOrDefaultAsync(c => c.Id == id);
        }


        public async Task<Checkout> AddCheckout(Checkout checkout)
        {
            await _db.Checkouts.AddAsync(checkout);
            await _db.SaveChangesAsync();
            return checkout;
        }

        public async Task<IEnumerable<Checkout>> GetAllCheckouts()
        {
            var checkouts =  await _db.Checkouts
                .Include(c => c.Book)
                    .ThenInclude(b => b.BookAuthors)
                        .ThenInclude(ba => ba.Author)
                .Include(c => c.Book)
                    .ThenInclude(b => b.Publisher).ToListAsync();
            checkouts.ForEach(c => c.Book.Authors = c.Book.BookAuthors.Select(ba => ba.Author).ToList());
            return checkouts;
        }

        public async Task<bool> DeleteCheckout(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateCheckout(Checkout checkout)
        {
            throw new NotImplementedException();

        }

        public async Task<bool> IsCheckedOut(int bookId)
        {
            var checkout =  await _db.Checkouts.FirstOrDefaultAsync(c => c.BookId == bookId && !c.IsReturned);
            if (checkout == null)
            {
                return false;
            }
            return true;
        }
    }
}
