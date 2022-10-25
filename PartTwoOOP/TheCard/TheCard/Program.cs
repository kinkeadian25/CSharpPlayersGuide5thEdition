List<Rank> ranks = Enum.GetValues(typeof(Rank)).Cast<Rank>().ToList();
List<Color> colors = Enum.GetValues(typeof(Color)).Cast<Color>().ToList();

foreach(var color in colors)
{
    foreach(var rank in ranks)
    {
        Console.WriteLine("The {0} {1}", color, rank);
    }
}
public class Card
{
    public Color Color { get; }
    public Rank Rank { get; }

    public Card(Color color, Rank rank)
    {
        Color = color;
        Rank = rank;
    }

    public string NumberOrSymbol()
    {
        if(Rank == Rank.Ampersand || Rank == Rank.DollarSign || Rank == Rank.Caret || Rank == Rank.Percent)
        {
            return "Your card is a symbol.";
        }
        else
        {
            return "Your card is a number.";
        }
    }
}

public enum Color { Red, Green , Blue, Yellow}
public enum Rank {One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Caret, Ampersand}