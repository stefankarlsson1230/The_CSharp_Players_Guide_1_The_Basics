// BMI Calculator - Ask for height and weight, then compute BMI.
// BMI = Weight in kg / (height in meters)^2

Console.Write("Height (m): ");
double height = double.Parse(Console.ReadLine());

Console.Write("Weight (kg): ");
double weight = double.Parse(Console.ReadLine());

double bmi = weight / Math.Pow(height, 2);

Console.WriteLine("BMI: " + bmi);
