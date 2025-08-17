
Console.Write("Enter value for x: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Enter value for y: ");
int y = int.Parse(Console.ReadLine());

string direction = "";

if (x == 0 && y == 0)
{
    Console.WriteLine("The Enemy is here!");
}
else if (x < 0)
{
    if (y < 0)
    {
        direction = "southwest";
    }
    else if (y == 0)
    {
        direction = "west";
    }
    else
    {
        direction = "northwest";
    }
}
else if (x == 0)
{
    if (y < 0)
    {
        direction = "south";
    }
    else
    {
        direction = "north";
    }
}
else if(x > 0)
{
    if (y < 0)
    {
        direction = "southeast";
    }
    else if (y == 0)
    {
        direction = "east";
    }
    else
    {
        direction = "norteast";
    }
}


if (x != 0 || y != 0)
{
    Console.WriteLine($"The enemy is to the {direction}!");
}


