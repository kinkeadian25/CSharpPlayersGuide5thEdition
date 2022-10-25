Console.Title = "Hunting the Manticore";

int number = AskForNumberInRange("Player 1 how far away from the city do you want to place the manicore?", 0, 100);

Console.Clear();

Console.WriteLine("Hunter attack the Manticore!");

int manticoreHealth = 10;
int cityHealth = 15;
int round = 1;

while (cityHealth >= 0 && manticoreHealth >= 0)
{
    ConsoleView(round, manticoreHealth, cityHealth, MagicCannon(1, 3, 5, 5));

    int guess = AskForNumber("Enter desired shot range: ");
    if (guess > number)
    {
        Console.WriteLine("You overshot your target.");
    }
    else if (guess < number)
    {
        Console.WriteLine("You undershot your target.");
    }
    else if (guess == number)
    {
        Console.WriteLine("Direct hit!");
        manticoreHealth = manticoreHealth - MagicCannon(1, 3, 5, 5);
        Console.ForegroundColor = ConsoleColor.White;
    }
    round++;
    cityHealth = cityHealth - 1;
    WinOrLose(manticoreHealth, cityHealth);
}

int AskForNumber(string text)
{
    Console.Write(text + " ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int number = AskForNumber(text);

        if (number > min && number < max)
        {
            return number;
        }
        else
        {
            Console.WriteLine("Please try again, number must be between 1 and 100");
        }
    }
}
void ConsoleView(int round,int manticoreHealth,int cityHealth, int magicCannon)
{
    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine("Status: Round: {0} City: {1}/15 Manticore: {2}/10",round, cityHealth, manticoreHealth);
    Console.WriteLine("Cannon is expected to deal {0} damage this round", magicCannon);
}

int MagicCannon(int normalDamage, int fireDamage, int electricDamage, int combinedDamage)
{
    if (round % electricDamage == 0 && round % fireDamage == 0)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        int cDamage = 5;
        return cDamage;
    }
    else if (round % fireDamage == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        int fDamage = 3;
        return fDamage;
    }
    else if (round % electricDamage == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        int eDamage = 3;
        return eDamage;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        int nDamage = 1;
        return nDamage;
    }
}
void WinOrLose(int manticoreHealth, int cityHealth)
{
    if (manticoreHealth <= 0)
    {
        Console.WriteLine("The Manticore was destroyed, and the city is safe!");
    }
    else if(cityHealth <= 0)
    {
        Console.WriteLine("The city was destroyed, we lost...");
    }
}