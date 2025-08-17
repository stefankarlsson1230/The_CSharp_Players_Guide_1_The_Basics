// Let user choose a foreground color

Console.WriteLine("Please enter one of the following colors:");
Console.WriteLine("\tDarkBlue");
Console.WriteLine("\tDarkYellow");
Console.WriteLine("\tGreen");
Console.WriteLine("\tRed");
Console.WriteLine("\tWhite");

// I don't quite get why I have to cast to ConsoleColor, but I think its because the Parse return a general Enum-type.
ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Console.ReadLine());

Console.ForegroundColor = color;

Console.WriteLine("This is the color of your choice!");
