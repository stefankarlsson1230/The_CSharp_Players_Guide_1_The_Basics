//Make a program that creates an array of length 5.
//Ask the user for five numbers and put them in the array.
//Make a second array of length 5.
//Use a loop to copy the values out of the original array and into the new one.
//Display the contents of both arrays one at a time to illustrate that the Replicator of D’To works again.

int[] firstArray = new int[5];

Console.WriteLine("Enter five numbers");

for(int i = 0; i < 5; i++)
{
    Console.Write($"Number {i+1}: ");
    int number = int.Parse( Console.ReadLine() );
    firstArray[i] = number;
}

int[] secondArray = new int[5];

// Could also use this -->  secondArray = firstArray[..]; 

for (int i = 0; i < 5; i++)
{
    secondArray[i] = firstArray[i];
}

Console.Write("First array: ");
for (int i = 0; i < 5; i++)
{
    Console.Write($"\t{firstArray[i]}");
}

Console.Write("\nSecond array: ");
for (int i = 0; i < 5; i++)
{
    Console.Write($"\t{secondArray[i]}");
}

