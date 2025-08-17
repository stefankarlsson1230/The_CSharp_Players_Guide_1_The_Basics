// Number Range - Check if number is in range 1–100.

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

if (number < 1 || number > 100)
{
    Console.WriteLine("Whooa!! That number is not in the range (1 - 100)");
}
else
{
    Console.WriteLine("Yep, that's between 1 and 100");
}

