// Tip Calculator - Ask for bill and tip percentage.

Console.Write("Bill: ");
double bill = double.Parse(Console.ReadLine());

Console.Write("Tip (%): ");
double tipPercent = double.Parse(Console.ReadLine());

double tip = (tipPercent / 100.0) * bill;

Console.WriteLine("You should tip " + tip );

