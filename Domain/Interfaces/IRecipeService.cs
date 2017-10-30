using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Domain.Interfaces
{
    public interface IRecipeService
    {
        void Add(Recipe recipe);
        void Update(Recipe recipe);
        void Delete(Recipe recipe);
        IEnumerable<Recipe> GetAll();
        IEnumerable<Recipe> FindAll(Expression<Func<Recipe, bool>> predicate);
        IEnumerable<Recipe> AllInclude(params string[] includeProperties);
        Recipe Find(int id, params string[] includeProperties);

    }
}
