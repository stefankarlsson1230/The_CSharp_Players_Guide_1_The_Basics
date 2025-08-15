//  Write a program that lets you input the triangle’s base size and height.
//  Compute the area of a triangle by turning the above equation into code.
//  Write the result of the computation.
//  Area = (base x height) / 2

float length;
float height;

Console.WriteLine("Calculating the area of a triangle\n");

Console.Write("Length: ");
length = float.Parse(Console.ReadLine());

Console.Write("Height: ");
height = float.Parse(Console.ReadLine());

Console.WriteLine("Area: " + (length * height / 2));

