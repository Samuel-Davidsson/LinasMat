using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> AllInclude(params string[] includeProperties);
        IQueryable<TEntity> GetAllIncluding(params string[] includeProperties);
        TEntity Find(Expression<Func<TEntity, bool>> predicate, params string[] includeProperties);
    }
}