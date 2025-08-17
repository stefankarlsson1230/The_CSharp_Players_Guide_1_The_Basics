// Voting Eligibility - Ask age, confirm if allowed to vote.

Console.Write("How old are you? ");
int age = int.Parse(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("You are allowed to vote!");
}
else
{
    Console.WriteLine("You are too young to vote!");
}

