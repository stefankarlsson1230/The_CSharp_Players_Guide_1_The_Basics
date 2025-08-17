// Prompt radius for a circle and compute area.

Console.Write("Radius of the circle: ");
double radius = double.Parse(Console.ReadLine());

double area = Math.Pow(radius, 2) * Math.PI;

Console.WriteLine("Area of the circle: " + area);
