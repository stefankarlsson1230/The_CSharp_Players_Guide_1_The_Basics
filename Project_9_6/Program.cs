// Password Gate - Prompt and validate secret password.

Console.WriteLine("(The secret password is \"secret\")");
Console.Write("Password: ");
string password = Console.ReadLine();

if (password == "secret")
{
    Console.WriteLine("Correct! You may pass");
}
else
{
    Console.WriteLine("That is NOT the password! Die rebel scum!");
}

