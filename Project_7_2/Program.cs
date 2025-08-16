// Create a program that lets the user enter the number of chocolate eggs gathered that day.

Write("Number of eggs: ");
int eggs = int.Parse(ReadLine());


// Using / and %, compute how many eggs each sister (4 sisters) should get and how many are left over for the duckbear.
int eggsPerSister = eggs / 4;
int eggsForDuckbear = eggs % 4;

WriteLine("The sisters will get " + eggsPerSister + " eggs each, and the duckbear " + eggsForDuckbear);

// Answer this question: What are three total egg counts where the duckbear gets more than each sister does?
// You can use the program you created to help you find the answer.
// 1, 2, 3, 6, 7, 11
