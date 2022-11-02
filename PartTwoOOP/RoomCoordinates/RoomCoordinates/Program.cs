Coordinate one = new Coordinate(1,2);
Coordinate two = new Coordinate(2,2);
Coordinate three = new Coordinate(1,2);

Console.WriteLine(Coordinate.AdjacentCoordinates(one, two));
Console.WriteLine(Coordinate.AdjacentCoordinates(one, three));
Console.WriteLine(Coordinate.AdjacentCoordinates(three, two));
public struct Coordinate
{
    public int X { get; }
    public int Y { get; }

    public Coordinate(int x, int y)
    {
        X = x; Y = y; 
    }
    public static bool AdjacentCoordinates(Coordinate coordinate1, Coordinate coordinate2)
    {
        int xChange = coordinate1.X - coordinate2.X;
        int yChange = coordinate1.Y - coordinate2.Y;

        if(xChange == 0 && yChange == 0)
        {
            return false;
        }
        if(xChange <= 1 && xChange >= -1)
        {
            return true;
        }
        if(yChange <= 1 && yChange >= -1)
        {
            return true;
        }
        return false;
    }
}