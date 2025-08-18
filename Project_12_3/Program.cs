// Reverse Array
// Print an array backwards.

int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

Console.Write("Forwards: ");
foreach(int i in array)
{
    Console.Write("\t" + i);
}

Console.WriteLine();

Console.Write("Backwards: ");
for(int i = array.Length - 1; i >= 0; i--)
{
    Console.Write("\t" + array[i]);
}

Console.WriteLine();

