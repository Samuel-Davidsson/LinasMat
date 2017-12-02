using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class RecipeIngredients
    {
        public int RecipeIngredientsID { get; set; }
        public int RecipeID { get; set; }
        public int IngredientID { get; set; }
        public Recipe Recipe { get; set; }
        public Ingredient Ingredient { get; set; }

    }
}
