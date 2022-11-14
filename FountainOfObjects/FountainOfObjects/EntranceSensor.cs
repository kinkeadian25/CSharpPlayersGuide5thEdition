public class EntranceSensor : ISensor
{
    public bool Sensor(FountainOfObjectsGame game)
    {
        if (game.Map.IsAtCoordinates(game.Player.Coordinates) == Area.Entrance)
        {
            PlayerTips.WriteLine(ConsoleColor.Yellow, "You finally see light, you know you are at the entrance.");
            Console.ForegroundColor = ConsoleColor.Gray;

            return true;
        }
        return false;
    }

}
