public class Player
{
    public Coordinates Coordinates { get; set; }
    public Player(Coordinates entrance)
    {
        Coordinates = entrance;
    }

    public static PlayerAction MakeMove()
    {
        ConsoleKey choice = Console.ReadKey(true).Key;
        PlayerAction action = choice switch
        {
            ConsoleKey.UpArrow => new MoveAction("Up"),
            ConsoleKey.DownArrow => new MoveAction("Down"),
            ConsoleKey.LeftArrow => new MoveAction("Left"),
            ConsoleKey.RightArrow => new MoveAction("Right"),
            ConsoleKey.Enter => new FixFountain(),
            _ => MakeMove(),
        };
        return action;

    }
}
