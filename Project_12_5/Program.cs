// Search Array
// Find if a value exists.

int[] numbers = [2, 6, 8];

Console.Write("Guess a number between 1 and 10: ");
int number = int.Parse(Console.ReadLine());

bool foundIt = false;

foreach(int i in numbers)
{
    if (number == i)
    {
        foundIt = true; 
        break;
    }
}

if (foundIt)
{
    Console.WriteLine("Yes! That number is in the array!");
}
else
{
    Console.WriteLine($"Nope, the array does not contain {number}");
}

