using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IReviewService
    {
        void Add(Review review);
        void Update(Review review);
        void Delete(Review review);
        IEnumerable<Review> GetAll();
        IEnumerable<Review> FindAll(Expression<Func<Review, bool>> predicate);
        IEnumerable<Review> AllInclude(params string[] includeProperties);
        Review Find(int id, params string[] includeProperties);
    }
}
