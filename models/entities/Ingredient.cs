namespace Cafe.models.entities;

public class Ingredient(string name, decimal price)
{
    public string Name { get; } = name;
    public decimal Price { get; } = price;
}