using Cafe.Data;
using Cafe.models.entities;
using Spectre.Console;

namespace Cafe.services;

public abstract class CafeService
{
    private static readonly List<Dish> Dishes = CafeFactory.CreateDishes();
    private static readonly List<Cook> Cooks = CafeFactory.CreateCooks();

    public static void ViewMenu()
    {
        UserInterface.GetMenu(Dishes);
    }

    public static void OrderDish()
    {
        var dishName = UserInterface.GetDishName(Dishes);
        var time = Dishes.Where(d => d.Name == dishName).Select(i => i.Time).First();

        var availableCooks = Cooks.FindAll(i => i.NumberOfOrders < 5).ToList()
            .OrderByDescending(i => i.TotalTimeForOrders + time).Last();
        availableCooks.Dishes.Add(Dishes.Single(d => d.Name == dishName));

        Console.WriteLine(
            $"The {dishName} will be dome by {availableCooks.Name} in about {availableCooks.TotalTimeForOrders} minutes. ");
        Console.WriteLine("Press any key to continue...");
        Console.ReadLine();
        Console.Clear();
    }
}