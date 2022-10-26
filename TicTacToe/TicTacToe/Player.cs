

public class Player
{
    private Value Value { get; set; }

    public Player(Value value)
    {
        Value = value;
    }

    public char PlayerChoice(char[] board)
    {
        Console.WriteLine("What block do you want to play in?");


        ConsoleKey choice = Console.ReadKey(true).Key;
        switch (choice)
        {
            case ConsoleKey.NumPad7:
                if (IsEmpty(board[6]))
                {
                    board[6] = ValueToChar(Value);
                    break;
                }
                PlayerChoice(board);
                break;
            case ConsoleKey.NumPad8:
                if (IsEmpty(board[7]))
                {
                    board[7] = ValueToChar(Value);
                    break;
                }
                PlayerChoice(board);
                break;
            case ConsoleKey.NumPad9:
                if (IsEmpty(board[8]))
                {
                    board[8] = ValueToChar(Value);
                    break;
                }
                PlayerChoice(board);
                break;
            case ConsoleKey.NumPad4:
                if (IsEmpty(board[3]))
                {
                    board[3] = ValueToChar(Value);
                    break;
                }
                PlayerChoice(board);
                break;
            case ConsoleKey.NumPad5:
                if (IsEmpty(board[4]))
                {
                    board[4] = ValueToChar(Value);
                    break;
                }
                PlayerChoice(board);
                break;
            case ConsoleKey.NumPad6:
                if (IsEmpty(board[5]))
                {
                    board[5] = ValueToChar(Value);
                    break;
                }
                PlayerChoice(board);
                break;
            case ConsoleKey.NumPad1:
                if (IsEmpty(board[0]))
                {
                    board[0] = ValueToChar(Value);
                    break;
                }
                PlayerChoice(board);
                break;
            case ConsoleKey.NumPad2:
                if (IsEmpty(board[1]))
                {
                    board[1] = ValueToChar(Value);
                    break;
                }
                PlayerChoice(board);
                break;
            case ConsoleKey.NumPad3:
                if (IsEmpty(board[2]))
                {
                    board[2] = ValueToChar(Value);
                    break;
                }
                PlayerChoice(board);
                break;
        }
        return ' ';
    }
    public bool IsEmpty(char c)
    {
        if (c != ValueToChar(Value.Empty))
        {
            Console.WriteLine("That block is taken try again");
            return false;
        }
        else
        {
            return true;
        }
    }
    public char ValueToChar(Value value)
    {
        if (value == Value.X)
        {
            return 'X';
        }
        else if(value == Value.O)
        {
            return 'O';
        }
        else
        {
            return ' ';
        }
    }
}
