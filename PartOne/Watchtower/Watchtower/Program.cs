Console.Title = "Watchtower";

Console.WriteLine("Please enter the coordinates:");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

if (x < 0 && y < 0)
{
    Console.WriteLine("Southwest!");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("Northwest!");
}
if (x < 0 && y == 0)
{
    Console.WriteLine("West!");
}
if (x == 0 && y < 0)
{
    Console.WriteLine("South!");
}
if (x == 0 && y == 0)
{
    Console.WriteLine("The enemy is here!");
}
if (x == 0 && y > 0)
{
    Console.WriteLine("North!!");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("Southeast!");
}
if (x > 0 && y == 0)
{
    Console.WriteLine("East!");
}
if (x > 0 && y > 0)
{
    Console.WriteLine("Northeast!");
}