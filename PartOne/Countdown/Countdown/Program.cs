Console.Title = "Countdown";

recursionLoop(10);

int recursionLoop(int number)
{
    if (number == 0) 
    {
        return 0;
    }
    Console.WriteLine(number);
    return recursionLoop(number - 1);
}