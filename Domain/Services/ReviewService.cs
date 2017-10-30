using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IRepository<Review> _repository;

        public ReviewService(IRepository<Review> repository)
        {
            _repository = repository;
        }

        public void Add(Review review)
        {
            _repository.Add(review);
        }

        public IEnumerable<Review> AllInclude(params string[] includeProperties)
        {
            return _repository.AllInclude(includeProperties);
        }

        public void Delete(Review review)
        {
            _repository.Delete(review);
        }

        public Review Find(int id, params string[] includeProperties)
        {
            return _repository.Find(x => x.Id == id, includeProperties);
        }

        public IEnumerable<Review> FindAll(Expression<Func<Review, bool>> predicate)
        {
            return _repository.FindAll(predicate);
        }

        public IEnumerable<Review> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Review review)
        {
            _repository.Update(review);
        }
    }
}
