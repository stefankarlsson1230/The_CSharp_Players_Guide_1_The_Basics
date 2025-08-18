// Multiplication Table
// Show a table 1–10.

for (int i = 1; i <= 10; i++)
{
    for(int j = 1; j <= 10; j++)
    {
        string expression = i + "x" + j + "=" + (i * j);
        Console.Write($"{expression, -10}");
    }

    Console.WriteLine();
}

