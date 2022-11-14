public class Map
{
    private readonly Area[,] _areas;
    public int Row { get; set; }
    public int Column { get; set; }

    public Map(int row, int column)
    {
        Row = row;
        Column = column;
        _areas = new Area[Row, Column];
    }

    public Area IsAtCoordinates(Coordinates coordinates)
    {
        if (ValidateArea(coordinates))
        {
            return _areas[coordinates.row, coordinates.column];
        }
        return Area.Wall;
    }

    public void SetAreaType(Coordinates coordinates, Area area)
    {
        _areas[coordinates.row, coordinates.column] = area;
    }

    public bool ValidateArea(Coordinates coordinates)
    {
        if(coordinates.row >= 0 && coordinates.column >= 0 && coordinates.row < _areas.GetLength(0) && coordinates.column < _areas.GetLength(1))
        {
            return true;
        }
        return false;
    }
}
