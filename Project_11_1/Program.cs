int answer;

// User 1 sets the answer
do
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    answer = int.Parse(Console.ReadLine());
}
while (answer < 0 || answer > 100);

Console.Clear();

// User 2 guesses the number
int guess;

Console.WriteLine("User 2, guess the number.");

while(true)
{
    Console.Write("What is your next guess? ");
    guess = int.Parse(Console.ReadLine());

    if (guess < answer)
    {
        Console.WriteLine($"{guess} is too low.");
    }
    else if (guess > answer)
    {
        Console.WriteLine($"{guess} is too high.");
    }
    else
    {
        Console.WriteLine("You guessed the number!");
        break;
    }
}


