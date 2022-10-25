Console.Title = "TakingANumber";

int number = AskForNumberInRange("Pilot please enter a number between 1 and 100:", 0, 100);

Console.Clear();    

Console.WriteLine("Hunter please attempt to guess the number.");

while (true)
{
    int guess = AskForNumber("What is your next guess?");
    if (guess > number)
    {
        Console.WriteLine("Your guess is too high.");
    }
    else if(guess < number)
    {
        Console.WriteLine("Your guess is too low.");
    }
    else
    {
        break;
    }
}

Console.WriteLine("You guessed the number!");


int AskForNumber(string text)
{
    Console.Write(text + " ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int number = AskForNumber(text);

        if(number > min && number < max)
        {
            return number;
        }
        else
        {
            Console.WriteLine("Please try again, number must be between 1 and 100");
        }
    }
}