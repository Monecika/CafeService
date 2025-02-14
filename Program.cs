using Cafe.models;
using Cafe.services;
using Spectre.Console;

namespace Cafe;

public class Program
{
    private static void Main()
    {
        CafeService.ViewMenu();
        while (true)
        {
            var option = AnsiConsole.Prompt
            (new SelectionPrompt<MenuOptions>()
                .AddChoices(
                    MenuOptions.ViewMenu,
                    MenuOptions.OrderDish,
                    MenuOptions.Quit
                ));

            Action action = option switch
            {
                MenuOptions.ViewMenu => CafeService.ViewMenu,
                MenuOptions.OrderDish => CafeService.OrderDish,
                MenuOptions.Quit => () =>
                {
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                },
                _ => () => { Console.WriteLine("Invalid option"); }
            };
            action();
        }
    }
}