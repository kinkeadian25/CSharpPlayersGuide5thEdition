(MealType mealType, MainIngredient ingredient, Seasoning seasoning) meal = BuildSoup();
Console.WriteLine($"You ordered: {meal.seasoning} {meal.ingredient} {meal.mealType}");

(MealType, MainIngredient, Seasoning) BuildSoup()
{
    MealType mealType = GetType();
    MainIngredient ingredient = GetIngredient();
    Seasoning seasoning = GetSeasoning();
    return (mealType, ingredient, seasoning);
}
MealType GetType()
{
    Console.WriteLine("Please select meal type by selecting a number:\n1 - Soup\n2 - Stew\n3 - Gumbo");
    int input = Convert.ToInt32(Console.ReadLine());
    if (input >= 1 && input <= 3)
    {
        switch (input)
        {
            case 1:
                return MealType.Soup;
            case 2:
                return MealType.Stew;
            case 3:
                return MealType.Gumbo;
        }
    }
    else
    {
        Console.WriteLine("Incorrect input, try again.");
        return GetType();
    }
    return 0;
}
MainIngredient GetIngredient()
{
    Console.WriteLine("Please select ingredient type by selecting a number:\n1 - Mushroom\n2 - Chicken\n3 - Carrot\n4 - Potato");
    int input = Convert.ToInt32(Console.ReadLine());
    if (input >= 1 && input <= 4)
    {
        switch (input)
        {
            case 1:
                return MainIngredient.Mushroom;
            case 2:
                return MainIngredient.Chicken;
            case 3:
                return MainIngredient.Carrot;
            case 4:
                return MainIngredient.Potato;
        }
    }
    else
    {
        Console.WriteLine("Incorrect input, try again.");
        return GetIngredient();
    }
    return 0;
}
Seasoning GetSeasoning()
{
    Console.WriteLine("Please select seasoning type by selecting a number:\n1 - Spicy\n2 - Salty\n3 - Sweet");
    int input = Convert.ToInt32(Console.ReadLine());
    if (input >= 1 && input <= 3)
    {
        switch (input)
        {
            case 1:
                return Seasoning.Spicy;
            case 2:
                return Seasoning.Salty;
            case 3:
                return Seasoning.Sweet;
        }
    }
    else
    {
        Console.WriteLine("Incorrect input, try again.");
        return GetSeasoning();
    }
    return 0;
}

enum MealType { Soup, Stew, Gumbo };
enum MainIngredient { Mushroom, Chicken, Carrot, Potato };
enum Seasoning { Spicy, Salty, Sweet }