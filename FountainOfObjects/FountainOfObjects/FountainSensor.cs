public class FountainSensor : ISensor
{
    public bool Sensor(FountainOfObjectsGame game)
    {
        if(game.Map.IsAtCoordinates(game.Player.Coordinates) == Area.Fountain)
        {
            PlayerTips.WriteLine(ConsoleColor.Cyan, "You hear dripping, you are in the fountain room.");
            Console.ForegroundColor = ConsoleColor.Gray;

            return true;
        }
        return false;
    }

}
