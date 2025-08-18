// Sum Until Zero - Sum inputs until 0 is entered.

int input;
int sum = 0;

Console.WriteLine("Enter integers to add. Finish by enter 0");

do
{
    Console.Write("Number to add: ");
    input = int.Parse(Console.ReadLine());
    sum += input;
}
while (input != 0);

Console.WriteLine($"Total sum = {sum}");

