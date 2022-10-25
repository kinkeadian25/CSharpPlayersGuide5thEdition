Console.Title = "Repair the Clocktower";
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.BackgroundColor = ConsoleColor.Cyan;

Console.WriteLine("Please provide what second it is on the clock");
int second = int.Parse(Console.ReadLine());

int secondRemainder = second % 2;

if (secondRemainder == 0)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}