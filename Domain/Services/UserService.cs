using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _repository;

        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }
        public void Add(User user)
        {
            _repository.Add(user);
        }

        public IEnumerable<User> AllInclude(params string[] includeProperties)
        {
            return _repository.AllInclude(includeProperties);
        }

        public void Delete(User user)
        {
            _repository.Delete(user);
        }

        public User Find(int id, params string[] includeProperties)
        {
            return _repository.Find(x => x.Id == id, includeProperties);
        }

        public IEnumerable<User> FindAll(Expression<Func<User, bool>> predicate)
        {
            return _repository.FindAll(predicate);
        }

        public IEnumerable<User> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(User user)
        {
            _repository.Update(user);
        }
    }
}
