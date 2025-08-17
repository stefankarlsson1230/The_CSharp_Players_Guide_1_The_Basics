// Typewriter Effect - Display a sentence character-by-character.

// I have to use loops and indexing in this even though the Book hasn't gotten so far yet (ChatGPT didn't give a fudge)
// I'm also using Thread.Sleep() to paus the program

Console.WriteLine("Typewriter effect!");
Console.Write("Enter message: ");
string message = Console.ReadLine()!;

Console.WriteLine();

for (int i = 0; i < message.Length; i++)
{
    Console.Write(message[i]);
    Thread.Sleep(200);
}

