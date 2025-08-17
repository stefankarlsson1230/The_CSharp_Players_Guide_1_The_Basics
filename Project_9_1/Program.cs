// Take a number as input from the console.
// Display the word “Tick” if the number is even. Display the word “Tock” if the number is odd.
// Hint: Remember that you can use the remainder operator to determine if a number is even or odd.

Console.Write("Enter number (integer): ");
int number = int.Parse(Console.ReadLine());

if (number % 2  == 0)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}

