using Cafe.models.entities;

namespace Cafe.Data;

public class CafeFactory
{
    private static List<Ingredient> CreateIngredients()
    {
        return
        [
            new Ingredient("Tomato", 1.5m),
            new Ingredient("Cheese", 2.0m),
            new Ingredient("Bread", 1.0m),
            new Ingredient("Potato", 0.8m)
        ];
    }

    public static List<Dish> CreateDishes()
    {
        var ingredients = CreateIngredients();

        return
        [
            new Dish("Sandwich",
                "A tasty Sandwich", [ingredients[0], ingredients[1]], 10),

            new Dish("Macarons", "Delicious French macarons", [ingredients[1], ingredients[2]],
                15),


            new Dish("Burger", "Juicy beef burger",
                [ingredients[0], ingredients[1], ingredients[2]], 20),


            new Dish("Pizza", "Cheesy pizza with tomato", [ingredients[0], ingredients[1]], 25),
            new Dish("Potato Fries", "Crispy potato fries", [ingredients[3]], 5)
        ];
    }

    public static List<Cook> CreateCooks()
    {
        var dishes = CreateDishes();
        return
        [
            new Cook("Ion", [dishes[0], dishes[1]]),
            new Cook("Mihai", [dishes[2], dishes[3]]),
            new Cook("Oleg", [dishes[4]])
        ];
    }
}