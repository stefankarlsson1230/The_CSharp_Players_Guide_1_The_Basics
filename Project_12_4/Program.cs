// Find Maximum - Show largest number.

int[] array = [-25, 34, 1, -6, 23, 12, -6, 22];

int largest = int.MinValue;

foreach (int i in array)
{
    if (i > largest)
    {
        largest = i;
    }
}

Console.WriteLine($"Largest value: {largest}");

