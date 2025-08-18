// Grades Average
// Store grades, compute average and pass/fail.

int[] grades = new int[3];

Console.WriteLine("Enter your grades (0 - 100).");

for (int i = 0; i < 3; i++)
{
    Console.Write($"{i+1}/3: ");
    grades[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("You need an average of 75 to pass");

double average = 0;

foreach (int i in grades)
{
    average += i;
}

average = average / grades.Length;

Console.WriteLine($"Your average: {average:#.##}");

if(average < 75)
{
    Console.WriteLine("You FAIL!");
}
else
{
    Console.WriteLine("Congratulations!! You PASS!");
}

