﻿using exercise.webapi.Data;
using exercise.webapi.Models.DatabaseModels;
using exercise.webapi.Models.JunctionModels;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        DataContext _db;
        private DbSet<T> _table_T = null;

        public Repository(DataContext db)
        {
            _db = db;
            _table_T = _db.Set<T>();
        }

        public async Task<T?> Get(int id) 
        {
            IQueryable<T> result = _table_T;
            if (typeof(T) == typeof(Book))
            {
                result = _table_T
                    .Include(b => (b as Book).BookAuthors)
                        .ThenInclude(ba => ba.Author)
                    .Include(b => (b as Book).Publisher)
                    .Where(e => EF.Property<int>(e, "BookId") == id);
            }
            else if (typeof(T) == typeof(Author))
            {
                result = _table_T
                    .Include(b => (b as Author).BookAuthors)
                        .ThenInclude(ba => (ba as BookAuthor).Book)
                            .ThenInclude(b => b.Publisher)
                    .Where(e => EF.Property<int>(e, "AuthorId") == id);
            }
            else if (typeof(T) == typeof(Publisher)) 
            {
                result = _table_T
                    .Include(p => (p as Publisher).Books)
                        .ThenInclude(b => (b as Book).BookAuthors)
                            .ThenInclude(ba => (ba as BookAuthor).Author)
                    .Where(e => EF.Property<int>(e, "Id") == id);
            }
            else
            {
                result = _table_T;
            }

            return await result.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            IQueryable<T> query = _table_T;
            if (typeof(T) == typeof(Book))
            {
                return await _table_T
                    .Include(b => (b as Book).BookAuthors)
                        .ThenInclude(ba => ba.Author)
                    .Include(b => (b as Book).Publisher)
                    .ToListAsync();
            }
            else if (typeof(T) == typeof(Author))
            {
                return await _table_T
                    .Include(b => (b as Author).BookAuthors)
                        .ThenInclude(ba => (ba as BookAuthor).Book)
                            .ThenInclude(b => b.Publisher)
                    .ToListAsync();
            }
            else if (typeof(T) == typeof(Publisher))
            {
                return await _table_T
                    .Include(p => (p as Publisher).Books)
                        .ThenInclude(b => (b as Book).BookAuthors)
                            .ThenInclude(ba => (ba as BookAuthor).Author)
                    .ToListAsync();
            }
            else 
            {
                return await _table_T.ToListAsync();
            }
        }

        public async Task<T> Update(int id, T entity)
        {
            var dbEntity = await _table_T.FindAsync(id);
            // Update values of the dbEntity
            _db.Entry(dbEntity).CurrentValues.SetValues(entity);
            await _db.SaveChangesAsync(); // Save changes
            return dbEntity;
        }

        public async Task<T> Insert(T entity)
        {
            var addedEntity = _table_T.Add(entity);
            await _db.SaveChangesAsync();
            return addedEntity.Entity;
        }

        public async Task<T> Delete(int id)
        {
            T? entity = _table_T.Find(id);
            _table_T.Remove(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(T entity)
        {
            _table_T.Remove(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
