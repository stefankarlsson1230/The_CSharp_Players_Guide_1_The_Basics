// Ask for birth year and compute current age.

int currentYear = 2025;

Console.Write("What year was you born? ");
int birthYear = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("You will be " + (currentYear - birthYear) + " years old this year");
