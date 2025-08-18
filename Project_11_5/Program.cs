// Retry Login
// Allow 3 attempts to enter password.

string password = "1234";
int attempts = 1;


while(true)
{
    if (attempts == 4)
    {
        Console.WriteLine("You are banned! Go away!");
        break;
    }

    Console.Write("Password: ");
    string input = Console.ReadLine();

    if (input == password)
    {
        Console.WriteLine("Welcome!");
        break;
    }

    attempts++;
}
