ChestState chestState = ChestState.Locked;

while (true)
{
    Console.Write("The chest is {0}. What do you want to do? ", chestState);

    string input = Console.ReadLine();
    input = input.ToLower();
    if (chestState == ChestState.Locked && input == "unlock")
    {
        chestState = ChestState.Closed;
    }
    if (chestState == ChestState.Closed && input == "open")
    {
        chestState = ChestState.Open;
    }
    if (chestState == ChestState.Open && input == "close")
    {
        chestState = ChestState.Closed;
    }
    if (chestState == ChestState.Closed && input == "lock")
    {
        chestState = ChestState.Locked;
    }
}
enum ChestState { Locked, Open, Closed }

