Robot robot = new Robot();

for (int i = 0; i < robot.Commands.Length; i++)
{
    string? input = Console.ReadLine();
    IRobotCommand newCommand = input switch
    {
        "on" => new OnCommand(),
        "off" => new OffCommand(),
        "north" => new MoveNorth(),
        "south" => new MoveSouth(),
        "east" => new MoveEast(),
        "west" => new MoveWest(),
        _ => throw new NotImplementedException()
    };
    robot.Commands[i] = newCommand;
}

Console.WriteLine();

robot.Run();


public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public IRobotCommand?[] Commands { get; } = new IRobotCommand?[3];
    public void Run()
    {
        foreach (IRobotCommand? command in Commands)
        {
            command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
}
public interface IRobotCommand
{
    public void Run(Robot robot);
}
public class OnCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}
public class OffCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}
public class MoveNorth : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y++;

        }
    }
}
public class MoveSouth : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y--;

        }
    }
}
public class MoveEast : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X++;

        }
    }
}
public class MoveWest : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X--;
        }
    }
}