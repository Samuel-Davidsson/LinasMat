using Domain.Interfaces;
using System;
using System.Collections.Generic;
using Domain.Entities;
using System.Linq.Expressions;

namespace Domain.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRepository<Recipe> _repository;

        public RecipeService(IRepository<Recipe> repository)
        {
            _repository = repository;
        }
        public void Add(Recipe recipe)
        {
            _repository.Add(recipe);
        }

        public IEnumerable<Recipe> AllInclude(params string[] includeProperties)
        {
            return _repository.AllInclude(includeProperties);
        }

        public void Delete(Recipe recipe)
        {
            _repository.Delete(recipe);
        }

        public Recipe Find(int id, params string[] includeProperties)
        {
            return _repository.Find(x => x.Id == id, includeProperties);
        }

        public IEnumerable<Recipe> FindAll(Expression<Func<Recipe, bool>> predicate)
        {
            return _repository.FindAll(predicate);
        }

        public IEnumerable<Recipe> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Recipe recipe)
        {
            _repository.Update(recipe);
        }

    }
}
