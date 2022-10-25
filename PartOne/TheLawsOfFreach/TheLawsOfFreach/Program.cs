using System.Xml.Schema;

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue;

foreach(int number in array)
{
    if(number < currentSmallest)
    {
        currentSmallest = number;
    }
}
Console.WriteLine(currentSmallest);
int total= 0;

foreach(int totalNumbers in array)
{
    total = total + totalNumbers;
}
float average = (float)total / array.Length;
Console.WriteLine(average);