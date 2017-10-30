using System.Collections.Generic;

namespace Domain.Entities
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgThumbnail { get; set; }

        ICollection<Ingredient> Ingredients { get; set; }
        ICollection<Review> Reviews { get; set; }
    }
}
