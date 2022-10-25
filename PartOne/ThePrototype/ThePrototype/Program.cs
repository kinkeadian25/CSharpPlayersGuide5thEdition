Console.Title = "The Prototype";

Console.Write("Pilot enter a number between 0 and 100: ");
int targetNumber = Convert.ToInt32(Console.ReadLine());

if (targetNumber < 0 || targetNumber > 100)
{
    Console.WriteLine("Number was not between 0 and 100, try again");
}
else
{
    Console.Clear();
}

Console.WriteLine("Hunter please attempt to guess the number");

int guessNumber;
do
{
    string playerGuess = Console.ReadLine();
    guessNumber = Convert.ToInt32(playerGuess);

    if(guessNumber < targetNumber)
    {
        Console.WriteLine("{0} is too low", guessNumber);
        Console.Write("What is your next guess? ");
    }
    else if(guessNumber > targetNumber)
    {
        Console.WriteLine("{0} is too high", guessNumber);
        Console.Write("What is your next guess? ");
    }
    
}
while (guessNumber != targetNumber);

Console.WriteLine("You guessed the number!");


