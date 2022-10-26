

public class Board
{
    public static void Create(char[] board)
    {
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
    }
}
