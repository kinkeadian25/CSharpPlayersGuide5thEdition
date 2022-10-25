Color green = Color.Green;
Color color = new Color(200, 100, 10);
Console.WriteLine($"Random Color: R:{color.R}, B:{color.B}, G:{color.G}");
Console.WriteLine($"Green: R:{green.R}, B:{green.B}, G:{green.G}");
public class Color
{
    public int R { get; set; }
    public int B { get; set; }
    public int G { get; set; }

    public Color(int r, int b, int g)
    {
        R = r;
        B = b;
        G = g;
    }

    public static Color White = new Color(255, 255, 255);
    public static Color Green = new Color(0, 128, 0);
    public static Color Blue = new Color(0, 0, 255);
    public static Color Black = new Color(0, 0, 0);
    public static Color Red = new Color(255, 0, 0);
    public static Color Purple = new Color(128, 0, 128);
    public static Color Yellow = new Color(255, 255, 0);
    public static Color Orange = new Color(255, 165, 0);
}