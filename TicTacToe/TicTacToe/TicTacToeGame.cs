
public class TicTacToeGame
{
    public char[] board = new char[] {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '};

    public void Start()
    {
        Player O = new Player(Value.O);
        Player X = new Player(Value.X);

        int turn = 1;
        while(turn < board.Length)
        {
            Board.Create(board);

            if (turn % 2 == 0)
            {
                Console.WriteLine("It is X's turn.");
                X.PlayerChoice(board);
                turn++;
            }
            else
            {
                Console.WriteLine("It is O's turn.");
                O.PlayerChoice(board);
                turn++;
            }
            
            if (WinCondition(board, Value.X))
            {
                Console.Clear();
                Board.Create(board);
                Console.WriteLine();
                Console.WriteLine("X wins!");
                return;
            }
            else if (WinCondition(board, Value.O))
            {
                Console.Clear();
                Board.Create(board);
                Console.WriteLine();
                Console.WriteLine("O wins!");
                return;
            }

            Console.Clear();

        }
    }

    public bool WinCondition(char[] board, Value value)
    {
        Player player = new Player(value);
        if (board[6] == player.ValueToChar(value) && board[7] == player.ValueToChar(value) && board[8] == player.ValueToChar(value)) { return true; }
        if (board[3] == player.ValueToChar(value) && board[4] == player.ValueToChar(value) && board[5] == player.ValueToChar(value)) { return true; }
        if (board[0] == player.ValueToChar(value) && board[1] == player.ValueToChar(value) && board[2] == player.ValueToChar(value)) { return true; }
        if (board[6] == player.ValueToChar(value) && board[3] == player.ValueToChar(value) && board[0] == player.ValueToChar(value)) { return true; }
        if (board[7] == player.ValueToChar(value) && board[4] == player.ValueToChar(value) && board[1] == player.ValueToChar(value)) { return true; }
        if (board[8] == player.ValueToChar(value) && board[5] == player.ValueToChar(value) && board[2] == player.ValueToChar(value)) { return true; }
        if (board[0] == player.ValueToChar(value) && board[4] == player.ValueToChar(value) && board[8] == player.ValueToChar(value)) { return true; }
        if (board[6] == player.ValueToChar(value) && board[4] == player.ValueToChar(value) && board[2] == player.ValueToChar(value)) { return true; }

        return false;
    }
}
