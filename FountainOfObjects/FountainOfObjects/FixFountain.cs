public class FixFountain : PlayerAction
{
    public override void Run(FountainOfObjectsGame game)
    {
        if (game.Map.IsAtCoordinates(game.Player.Coordinates) == Area.Fountain)
        {
            game.FountainStatus = true;
            PlayerTips.WriteLine(ConsoleColor.Green, "The waters begin rushing! you have fixed the fountain! Head to the entrance to escape!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        else
        {
            PlayerTips.WriteLine(ConsoleColor.Red, "You are not in the fountain room, keep looking!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
