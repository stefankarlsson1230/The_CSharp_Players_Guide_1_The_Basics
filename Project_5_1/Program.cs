// Store and Print – Store your age, name, and city in variables and print them.
using System.Security.Cryptography.X509Certificates;

int age = 50;
string name = "Stefan";
string city = "Linköping";

WriteLine("My name is " + name + ", I am " + age + " years old and live in " + city);

WriteLine("\n");

// Swap Variables – Swap two variables and print the result.
WriteLine("name = " + name);
WriteLine("city = " + city);
WriteLine("Swapping!!");
string temp = name;
name = city;
city = temp;
WriteLine("name = " + name);
WriteLine("city = " + city);

// Travel Budget – Calculate total trip cost with basic math.
int food = 500;
int flight = 2000;
int spending_money = 25000;
int total = food + flight + spending_money;

WriteLine("\n");

// Hobby Info – Store details about a hobby and output them.
string favoriteRPG = "Call of Cthulhu";
int startedPlayingAt = 10;
WriteLine("I started playing at the age of " + startedPlayingAt + " and My favourite roleplaying game is " + favoriteRPG);

WriteLine("\n");

// Temperature Converter – Convert Celsius to Fahrenheit.
// F = C * 1.8 + 32
int celsius = 30;
WriteLine(celsius + "C = " + (celsius * 1.8 + 32) + "F");
