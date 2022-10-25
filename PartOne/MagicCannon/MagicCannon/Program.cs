Console.Title = "The Magic Cannon";

int fire = 3;
int electric = 5;

for (int shotNumber = 1; shotNumber <= 100; shotNumber++)
{
    if(shotNumber % fire == 0 && shotNumber % electric == 0)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Combined Blast");
    }
    else if (shotNumber % fire == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Fire");
    }
    else if(shotNumber % electric == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Electric");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Normal");
    }
}