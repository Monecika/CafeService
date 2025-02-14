using Cafe.models.entities;
using Spectre.Console;

namespace Cafe.services;

public abstract class UserInterface
{
    public static void GetMenu(List<Dish> dishes)
    {
        Table table = new();
        table.AddColumn("Name");
        table.AddColumn("Description");
        table.AddColumn("Ingredients");
        table.AddColumn("Price");

        foreach (var dish in dishes)
        {
            var ingredients = string.Join(", ", dish.Ingredients.Select(i => i.Name));
            table.AddRow(dish.Name, dish.Description, ingredients, $"{dish.Price:C}");
        }

        AnsiConsole.Write(table);
        Console.WriteLine("Press any key to continue...");
        Console.ReadLine();
        Console.Clear();
    }

    public static string GetDishName(List<Dish> dishes)
    {
        return AnsiConsole.Prompt(new SelectionPrompt<string>().Title("Choose the product you want to order: ")
            .AddChoices(dishes.Select(i => i.Name)));
    }
}