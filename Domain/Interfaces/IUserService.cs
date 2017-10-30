using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IUserService
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        IEnumerable<User> GetAll();
        IEnumerable<User> FindAll(Expression<Func<User, bool>> predicate);
        IEnumerable<User> AllInclude(params string[] includeProperties);
        User Find(int id, params string[] includeProperties);
    }
}
