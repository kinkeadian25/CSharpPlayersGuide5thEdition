Coordinates entrance = new Coordinates(0, 0);
Coordinates fountain = new Coordinates(0, 2);
Map map = new Map(4,4);
map.SetAreaType(fountain, Area.Fountain);
map.SetAreaType(entrance, Area.Entrance);
Player player = new Player(entrance);

FountainOfObjectsGame game = new FountainOfObjectsGame(map, player);
game.Start();



public class FountainOfObjectsGame
{
    public Map Map { get; set; }
    public Player Player { get; set; }
    public List<ISensor> Sensors;
    public bool FountainStatus { get; set; }
    
    public FountainOfObjectsGame(Map map, Player player)
    {
        Map = map;
        Player = player;
        Sensors = new List<ISensor>() { new FountainSensor(), new EntranceSensor() };
    }

    public void Start()
    {
        bool WinCondition = false;

        while (!WinCondition)
        {
            GameUI();
            PlayerAction action = Player.MakeMove();
            action.Run(this);
            if(FountainStatus && Map.IsAtCoordinates(Player.Coordinates) == Area.Entrance)
            {
                WinCondition = true;
                Console.WriteLine("You win!");
            }
            else
            {
                WinCondition = false;
            }

        }
    }
    private void GameUI()
    {
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine($"You are at the coordinates (Row: {Player.Coordinates.row}, Column: {Player.Coordinates.column})");
        foreach(var sensor in Sensors)
        {
            sensor.Sensor(this);
        }
        Console.WriteLine("What do you want to do?\nUse the directional pad to navigate, and use enter to attemp fountain activation.");

    }
}

public record class Coordinates(int row, int column);
public enum Area { Empty, Fountain, Entrance, Wall}