using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Exceptions;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class CheckoutRepository(DataContext db) : IRepository<Checkout>
    {
        DataContext _db = db;

        public async Task<Checkout> Add(Checkout entity)
        {
            await _db.Checkouts.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<Checkout> Delete(int id)
        {
            Checkout checkout = await Get(id);
            _db.Checkouts.Remove(checkout);
            await _db.SaveChangesAsync();
            return checkout;
        }

        public async Task<Checkout> Get(int id)
        {
            Checkout? checkout = await _db.Checkouts.Include(p => p.Book).ThenInclude(b => b.Authors).Include(p => p.Book).ThenInclude(b => b.Publisher).SingleOrDefaultAsync(x => x.Id == id);
            if (checkout == null) throw new IdNotFoundException("The provided checkout Id does not exist!");
            return checkout;
        }

        public async Task<IEnumerable<Checkout>> GetAll()
        {
            return await _db.Checkouts.Include(checkout => checkout.Book).ThenInclude(b => b.Authors).Include(p => p.Book).ThenInclude(b => b.Publisher).ToListAsync();
        }

        public async Task<Checkout> Update(Checkout entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _db.Checkouts.Attach(entity);
                _db.Entry(entity).State = EntityState.Modified;
            }

            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
