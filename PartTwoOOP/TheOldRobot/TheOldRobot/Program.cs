Robot robot = new Robot();

for (int i = 0; i < robot.Commands.Length; i++)
{
    string? input = Console.ReadLine();
    RobotCommand newCommand = input switch
    {
        "on" => new OnCommand(),
        "off" => new OffCommand(),
        "north" => new MoveNorth(),
        "south" => new MoveSouth(),
        "east" => new MoveEast(),
        "west" => new MoveWest(),
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
    public RobotCommand?[] Commands { get; } = new RobotCommand?[3];
    public void Run()
    {
        foreach (RobotCommand? command in Commands)
        {
            command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
}
public abstract class RobotCommand
{
    public abstract void Run(Robot robot);
}
public class OnCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}
public class OffCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}
public class MoveNorth : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y++;

        }
    }
}
public class MoveSouth : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y--;

        }
    }
}
public class MoveEast : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X++;

        }
    }
}
public class MoveWest : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X--;
        }
    }
}