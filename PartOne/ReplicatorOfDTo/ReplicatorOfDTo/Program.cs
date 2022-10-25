Console.Title = "Replicator of D'To";

int[] original = new int[5];

for(int i = 0; i < 5; i++)
{
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    original[i] = number;
}
int[] copy = new int[5];
for (int i = 0; i < 5; i++)
{
    copy[i] = original[i];
}
for(int i = 0; i < 5; i++)
{
    Console.WriteLine(copy[i] + " and " + original[i]);
}