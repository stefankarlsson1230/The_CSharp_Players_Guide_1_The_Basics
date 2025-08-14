//  Build a program with a variable of all fourteen types described in this level.
byte aByte;
sbyte aSignedByte;
short aShort;
ushort anUnsignedShort;
int anInt;
uint anUnsignedInt;
long aLong;
ulong anUnsignedLong;

char aChar;

float aFloat;
double aDouble;
decimal aDecimal;

string aString;

bool aBoolean;


//  Assign each of them a value using a literal of the correct type.
aByte = 200;
aSignedByte = -120;
aShort = -28000;
anUnsignedShort = 62000;
anInt = -2_000_000_001;
anUnsignedInt = 4_000_000_000;
aLong = -8_000_000_000_000_000_111;
anUnsignedLong = 18_000_000_000_000_000_111;

aChar = 'B';

aFloat = 1.45e-32f;
aDouble = -4.5674e-322;
aDecimal = -3.456284957389456m;

aString = "Hello!";

aBoolean = true;


//  Use Console.WriteLine to display the contents of each variable.
Console.WriteLine("A Byte: " + aByte);
Console.WriteLine("A Signed Byte: " + aSignedByte);
Console.WriteLine("A Short: " + aShort);
Console.WriteLine("An Unsigned Short: " + anUnsignedShort);
Console.WriteLine("An Int: " + anInt);
Console.WriteLine("An Unsigned Int: " + anUnsignedInt);
Console.WriteLine("A Long: " + aLong);
Console.WriteLine("An Unsigned Long: " + anUnsignedLong);
Console.WriteLine("A Char: " + aChar);
Console.WriteLine("A Float: " + aFloat);
Console.WriteLine("A Double: " + aDouble);
Console.WriteLine("A Decimal: " + aDecimal);
Console.WriteLine("A String: " + aString);
Console.WriteLine("A Boolean: " + aBoolean);


// Modify your Variable Shop program to assign a new, different literal value to each of the 14 original variables. Do not declare any additional variables.
aByte = 128;
aSignedByte = -56;
aShort = -32000;
anUnsignedShort = 44000;
anInt = -1_458_000_001;
anUnsignedInt = 2_111_222_000;
aLong = -9_000_111_000_000_000_111;
anUnsignedLong = 8_999_000_000_000_000_111;

aChar = 'C';

aFloat = -1.45e32f;
aDouble = 4.5674e300;
aDecimal = 8.4562849573894563m;

aString = "Good Bye!";

aBoolean = false;


// Use Console.WriteLine to display the updated contents of each variable. 

Console.WriteLine("\nNew Values!\n");

Console.WriteLine("A Byte: " + aByte);
Console.WriteLine("A Signed Byte: " + aSignedByte);
Console.WriteLine("A Short: " + aShort);
Console.WriteLine("An Unsigned Short: " + anUnsignedShort);
Console.WriteLine("An Int: " + anInt);
Console.WriteLine("An Unsigned Int: " + anUnsignedInt);
Console.WriteLine("A Long: " + aLong);
Console.WriteLine("An Unsigned Long: " + anUnsignedLong);
Console.WriteLine("A Char: " + aChar);
Console.WriteLine("A Float: " + aFloat);
Console.WriteLine("A Double: " + aDouble);
Console.WriteLine("A Decimal: " + aDecimal);
Console.WriteLine("A String: " + aString);
Console.WriteLine("A Boolean: " + aBoolean);

