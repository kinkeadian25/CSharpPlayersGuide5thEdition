ColoredItem<Sword> sword = new ColoredItem<Sword>(new Sword(), ConsoleColor.DarkCyan);
ColoredItem<Bow> bow = new ColoredItem<Bow>(new Bow(), ConsoleColor.Magenta);
ColoredItem<Axe> axe = new ColoredItem<Axe>(new Axe(), ConsoleColor.Red);

sword.Display();
bow.Display();
axe.Display();
Console.ForegroundColor = ConsoleColor.Gray;

public class Sword { }
public class Bow { }
public class Axe { }

public class ColoredItem<T>
{
    public T Weapon { get; }
    public ConsoleColor Color { get; }

    public ColoredItem(T weapon, ConsoleColor color)
    {
        Weapon = weapon;
        Color = color;
    }
    public void Display()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine(Weapon);
    }
} 