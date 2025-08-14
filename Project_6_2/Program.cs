using System.Globalization;

//  Type Conversion – Convert string to int and perform addition.
Write("Enter first number: ");
string number1 = ReadLine();
Write("Enter second number: ");
string number2 = ReadLine();

WriteLine(number1 + " + " + number2 + " = " + (int.Parse(number1) + int.Parse(number2)));


//  Character Codes – Print a few char values and their Unicode codes.
WriteLine();   
char a = 'a';
char z = 'z';
char newLine = '\n';

WriteLine("The char a has the unicode value " + (int)a);
WriteLine("The char z has the unicode value " + (int)z);
WriteLine("The newLine (\\n) char has the unicode value " + (int)newLine);


//  Type Summary – Print the size of each basic numeric type.
WriteLine();
WriteLine("Byte: " + sizeof(byte) + " bytes");
WriteLine("Short: " + sizeof(short) + " bytes");
WriteLine("Int: " + sizeof(int) + " bytes");
WriteLine("Long: " + sizeof(long) + " bytes");
WriteLine("Float: " + sizeof(float) + " bytes");
WriteLine("Double: " + sizeof(double) + " bytes");
WriteLine("Decimal: " + sizeof(decimal) + " bytes");
WriteLine("Char: " + sizeof(char) + " bytes");


//  Type Check – Use GetType() to confirm data types.
WriteLine();

int value = 23;

if(value.GetType() == typeof(int))
{
    WriteLine("It's an int!");
}

