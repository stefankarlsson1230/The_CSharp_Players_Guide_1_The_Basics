// Grade Checker – Return letter grade from score.

// 90+      A
// 80 - 89  B
// 70 - 79  C
// 60 - 69  D
// 0 - 59   F

Console.Write("What is your score? (0 - 100) ");
int score = int.Parse(Console.ReadLine());

char grade;

if (score >= 90)
{
    grade = 'A';
}
else if (score >= 80)
{
    grade = 'B';
}
else if (score >= 70)
{
    grade = 'C';
}
else if (score >= 60)
{
    grade = 'D';
}
else
{
    grade = 'F';
}


Console.WriteLine($"Your grade is {grade}");

