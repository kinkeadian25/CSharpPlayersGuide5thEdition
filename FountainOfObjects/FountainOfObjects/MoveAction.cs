public class MoveAction : PlayerAction
{
    public string Movement { get; set; }

    public MoveAction(string movement)
    {
        Movement = movement;
    }

    public override void Run(FountainOfObjectsGame game)
    {
        Coordinates coordinates = game.Player.Coordinates;
        Coordinates newCoordinates = Movement switch
        {
            "Left" => new Coordinates(coordinates.row, coordinates.column - 1),
            "Right" => new Coordinates(coordinates.row, coordinates.column + 1),
            "Up" => new Coordinates(coordinates.row + 1, coordinates.column),
            "Down" => new Coordinates(coordinates.row - 1, coordinates.column),
            _ => throw new NotImplementedException(),
        };
        if (game.Map.ValidateArea(newCoordinates))
        {
            game.Player.Coordinates = newCoordinates;
        }
        else
        {
            PlayerTips.WriteLine(ConsoleColor.DarkMagenta, "There is nothing to adventure in that direction! Try again!");
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
