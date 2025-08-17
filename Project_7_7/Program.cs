// Average Finder - Ask for 3 numbers, compute average. 

double x, y, z;

Console.Write("First number: ");
x = double.Parse(Console.ReadLine());

Console.Write("Second number: ");
y = double.Parse(Console.ReadLine());

Console.Write("Third number: ");
z = double.Parse(Console.ReadLine());

double average = (x + y + z ) / 3;

Console.WriteLine("The average is: " + average);

