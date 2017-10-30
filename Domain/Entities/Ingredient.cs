namespace Domain.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ammount { get; set; }

        public FoodType FoodType { get; set; }
    }

    public enum FoodType
    {
        Chicken,
        Vegan,
        Pork,
        Beef,
        Fish,
        Seafood
    }
}
