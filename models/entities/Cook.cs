using System.Net.Http.Headers;

namespace Cafe.models.entities;

public class Cook(string name, List<Dish> dishes)
{
    public string Name { get; } = name;
    public List<Dish> Dishes { get; set; } = dishes;

    public int NumberOfOrders => Dishes.Count;

    public int TotalTimeForOrders => Dishes.Sum(i => i.Time);
}