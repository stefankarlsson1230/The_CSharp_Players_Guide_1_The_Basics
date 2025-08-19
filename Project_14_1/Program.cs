// Variables
using System.Runtime.Intrinsics.Arm;

int manticoreHP = 10;
int cityHP = 15;
int round = 1;
int manticorePosition = -1;
int cityAim;
int damage;


// Player 1
while (manticorePosition < 0 || manticorePosition > 100)
{
    Console.Write("Player 1, how far away from the city do you want to station the Manticore? (0 - 100): ");
    manticorePosition = int.Parse(Console.ReadLine());
    Console.Clear();
}

// Player 2
Console.WriteLine("Player 2, it is your turn.");

while(manticoreHP > 0 && cityHP > 0)
{
    damage = GetCannonDamage(round);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("-----------------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine($"STATUS: Round: {round}  City: {cityHP}/15  Manticore: {manticoreHP}/10");
    Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");
    Console.Write("Enter desired cannon range: ");
    cityAim = int.Parse(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.Blue;
    if (cityAim > manticorePosition)
    {
        Console.WriteLine("That round OVERSHOT the target.");
    }
    else if (cityAim < manticorePosition)
    {
        Console.WriteLine("That round FELL SHORT of the target.");
    }
    else
    {
        Console.WriteLine("That round was a DIRECT HIT!");
        manticoreHP -= damage;
    }
    cityHP--;
    round++;
}

// Resolution
if (manticoreHP <= 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("The city is lost!! Flee you fools!!");
}


    // ---------- Local Functions ------------
    int GetCannonDamage(int round)
    {
        if (round % 3 == 0 && round % 5 == 0)
        {
            return 10;
        }
        else if (round % 3 == 0 || round % 5 == 0)
        {
            return 3;
        }
        else
        {
            return 1;
        }
    }
