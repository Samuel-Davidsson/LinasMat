using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Context
{
    public class DbInitializer
    {
       public static void Initialize(LinasMatkasseContext context)
        {
            context.Database.EnsureCreated();

            if (context.Recipe.Any() && context.Review.Any())
            {
                return;
            }

            var recipe1 = new Recipe { Name = "Köttbullar i gräddsås med potatis och lingon", Description = "Stek köttbullarna, koka potatisen och öppna ligonburken", ImgThumbnail = "http://1.bp.blogspot.com/-eIj4HiJ-2ww/T-V5IOV0jaI/AAAAAAAAA3E/hP5AslXmI24/s1600/stora+k%C3%B6ttbullar.jpg" };
            var recipe2 = new Recipe { Name = "Hamburgare i surdegsbröd med picklad rödlök", Description = "Skala löken och lägg den i en burk med lite socker och vitvinsvinäger, öppna hamburgarna och stek dom", ImgThumbnail = "https://i1.wp.com/www.sandrasmatkrypin.se/wp-content/uploads/2017/09/P7200134.jpg?fit=1200%2C900&resize=350%2C200" };
            var recipe3 = new Recipe { Name = "Mexicansk grönsakspizza med tacotopping", Description="Skala alla grönsaker, koka upp tomatsåsen lägg allt på pizza och stoppa den i ugnen i 20 min", ImgThumbnail= "http://1.bp.blogspot.com/-OTwT5aeS0-U/VFKh65BJ_uI/AAAAAAAAPQo/TL5ixq02i2Y/s1600/2014-10-30%2B-%2B1" };
            var recipies = new Recipe[]
            {
                recipe1, recipe2, recipe3
            };
            context.Recipe.AddRange(recipies);
            context.SaveChanges();

            var ingredient1 = new Ingredient { Name = "Pizzasås",  };
            var ingredient2 = new Ingredient { Name = "Röd Paprika" };
            var ingredient3 = new Ingredient { Name = "Gul Lök" };
            var ingredient4 = new Ingredient { Name = "Zucchini" };
            var ingredient5 = new Ingredient { Name = "Pizza Deg" };
            var ingredient6 = new Ingredient { Name = "Ligonsylt" };
            var ingredient7 = new Ingredient { Name = "Vispgrädde" };
            var ingredient8 = new Ingredient { Name = "Potatis" };
            var ingredient9 = new Ingredient { Name = "Hamburgare" };
            var ingredient10 = new Ingredient { Name = "Nötfärs" };

            var ingredients = new Ingredient[]
            {
                ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6,ingredient7,ingredient8,ingredient9,ingredient10
            };
            context.Ingredient.AddRange(ingredients);
            context.SaveChanges();

            var recipeIngredients = new RecipeIngredients[]
            {
                new RecipeIngredients{Recipe=recipe1, Ingredient=ingredient6},
                new RecipeIngredients{Recipe=recipe1, Ingredient=ingredient10},
                new RecipeIngredients{Recipe=recipe1, Ingredient=ingredient8},
                new RecipeIngredients{Recipe=recipe1, Ingredient=ingredient7},

                new RecipeIngredients{Recipe=recipe2, Ingredient=ingredient9},
                new RecipeIngredients{Recipe=recipe2, Ingredient=ingredient3},

                new RecipeIngredients{Recipe=recipe3, Ingredient=ingredient3},
                new RecipeIngredients{Recipe=recipe3, Ingredient=ingredient4},
                new RecipeIngredients{Recipe=recipe3, Ingredient=ingredient2},
                new RecipeIngredients{Recipe=recipe3, Ingredient=ingredient1},
                new RecipeIngredients{Recipe=recipe3, Ingredient=ingredient5}
            };
            context.RecipeIngredients.AddRange(recipeIngredients);
            context.SaveChanges();
    }
    }
}
