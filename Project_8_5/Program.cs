// Print a centered greeting using padding


Console.Write("Enter a greeting to be centered: ");
string greeting  = Console.ReadLine();

Console.WriteLine("\n");

// I don't think the book has talked about the String.Length property, but I need to use that here

int consoleWidth = Console.WindowWidth;
int width = greeting.Length + (consoleWidth - greeting.Length) / 2;

Console.WriteLine(greeting.PadLeft(width));

