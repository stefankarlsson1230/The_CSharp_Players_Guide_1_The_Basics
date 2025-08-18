//  Modify your program from before to also ask the user for their name.
//  If their name equals your name, divide the cost in half.


Console.WriteLine("The Following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.Write("What number do you want to see the price of? ");

int choice = int.Parse(Console.ReadLine());

string myName = "Stefan";
string name;
string item;
int price;

item = choice switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies",
    _ => "We don't have that!"
};

price = choice switch
{
    1 => 10,
    2 => 16,
    3 => 24,
    4 => 2,
    5 => 20,
    6 => 200,
    7 => 2,
    _ => 0
};


if (price == 0)
{
    Console.WriteLine(item);
}
else
{
    Console.Write("What is your name? ");
    name = Console.ReadLine();

    if (name == myName)
    {
        price /= 2;
    }

    Console.WriteLine($"{item} cost {price} gold");
}
