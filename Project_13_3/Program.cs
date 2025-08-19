// Simple Adder – Create and call an Add() method.
using System.Text.Json.Serialization;

int Add(int x, int y)
{
    return x + y;
}

Console.WriteLine(Add(1, 1));


// Greeting Method – Pass a name and return a greeting.
void Greeting(string name)
{
    Console.WriteLine("Hello " + name + "!");
}

Greeting("Thomas");


// Temperature Converter – Create method to convert Fahrenheit to Celsius.
// C = (F-32)*5/9
double FarenheitToCelsius(double fahrenheit)
{
    return (fahrenheit - 32) * 5 / 9;
}

Console.WriteLine($"12 Fahrenheit = {FarenheitToCelsius(12.0):0.00} Celsius");


// Max Method – Return the greater of two numbers.
int Greater(int x, int y) => x > y ? x : y;

Console.WriteLine(Greater(-5, -99));


// Factorial – Compute using recursion.
int Factorial(int n)
{
    if (n == 1)
    {
        return 1;
    }
    else
    {
        return n * Factorial(n - 1);
    }
}

Console.WriteLine("5! = " + Factorial(5));

