using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IRepository<Ingredient> _repository;

        public IngredientService(IRepository<Ingredient> repository)
        {
            _repository = repository;
        }
        public void Add(Ingredient ingredient)
        {
            _repository.Add(ingredient);
        }

        public IEnumerable<Ingredient> AllInclude(params string[] includeProperties)
        {
            return _repository.AllInclude(includeProperties);
        }

        public void Delete(Ingredient ingredient)
        {
            _repository.Delete(ingredient);
        }

        public Ingredient Find(int id, params string[] includeProperties)
        {
            return _repository.Find(x => x.Id == id, includeProperties);
        }

        public IEnumerable<Ingredient> FindAll(Expression<Func<Ingredient, bool>> predicate)
        {
            return _repository.FindAll(predicate);
        }

        public IEnumerable<Ingredient> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Ingredient ingredient)
        {
            _repository.Update(ingredient);
        }
    }
}
