
//  Make a method with the signature int AskForNumber(string text). Display the text parameter in 
//  the console window, get a response from the user, convert it to an int, and return it.
//  This might look like this: int result = AskForNumber("What is the airspeed velocity
//  of an unladen swallow ? ");.
int AskForNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}


//  Make a method with the signature int AskForNumberInRange(string text, int min, int
//  max).Only return if the entered number is between the min and max values.Otherwise, ask again.
int AskForNumberInRange(string text, int min, int max)
{
    while(true)
    {
        Console.Write(text);
        int number = int.Parse(Console.ReadLine());
        if (number >= min && number <= max)
        {
            return number;
        }
    }
}

