public static class PlayerTips
{
    public static void WriteLine(ConsoleColor color, string text)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
    }
    public static void Write(ConsoleColor color, string text)
    {
        Console.ForegroundColor = color;
        Console.Write(text);
    }
}
