using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IIngredientService
    {
        void Add(Ingredient ingredient);
        void Update(Ingredient ingredient);
        void Delete(Ingredient ingredient);
        IEnumerable<Ingredient> GetAll();
        IEnumerable<Ingredient> FindAll(Expression<Func<Ingredient, bool>> predicate);
        IEnumerable<Ingredient> AllInclude(params string[] includeProperties);
        Ingredient Find(int id, params string[] includeProperties);
    }
}
