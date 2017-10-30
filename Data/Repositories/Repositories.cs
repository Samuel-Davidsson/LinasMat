using Data.Context;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Data.Repositories
{
    public class Repositories<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _set;

        public Repositories()
        {
            _context = new LinasMatkasseContext();
            _set = _context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _set.Add(entity);
            _context.Entry(entity);
            _context.SaveChanges();
        }
        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _set.Update(entity);
            _context.SaveChanges();
        }
        public void Delete(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
            _set.Remove(entity);
            _context.SaveChanges();
        }
        public TEntity Find(Expression<Func<TEntity, bool>> predicate, params string[]includeProperties)
        {
            return GetAllIncluding(includeProperties).Where(predicate).ToList().FirstOrDefault()
                ?? throw new KeyNotFoundException($"Entity not found");
        }

        public IQueryable<TEntity> GetAllIncluding(params string[] includeProperties)
        {
            var queryable = _set as IQueryable<TEntity>;

            return includeProperties.Aggregate
                (queryable, (current, includeProperty) => current.Include(includeProperty));
        }

        public IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate) 
        {
            return _set.Where(predicate).ToList();
        }

        public IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate,
           params string[] includeProperties)
        {
            return GetAllIncluding(includeProperties).Where(predicate).ToList();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _set.ToList();
        }

        public IEnumerable<TEntity> AllInclude(params string[] includeProperties)
        {
            return GetAllIncluding(includeProperties).ToList();
        }
    }

}
