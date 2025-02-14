namespace Cafe.models.entities;

public class Dish(string name, string description, List<Ingredient> ingredients, int time)
{
    public string Name { get; } = name;
    public string Description { get; } = description;
    public List<Ingredient> Ingredients { get; } = ingredients;

    public decimal Price => Ingredients.Sum(i => i.Price);
    public int Time { get; } = time;
}