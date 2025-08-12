# The C# Player's Guide - Part 1: The Basics

## Chapter 1: The C# Programming Language

### From ChatGPT
- [x] Project 1
  - What is C#? - Print a one-line description.
  - Why Learn to Code? - Print your personal motivation.
  - Hello Programmer - Print “I’m learning C#!”
  - Real-World Uses - Print 3 things C# can build.
  - Describe a Program - Write a comment that explains what a program does.
- *Comments*
  - *I merged these 5 small projects into one*


## Chapter 2: Getting an IDE

### From The book & ChatGPT
- [x] Project 1
  - Install Visual Studio 2022 Community edition (or another IDE) and get it ready to start programming.
  - Launch and Explore – Open your IDE and create a blank project.
  - Identify Components – Comment the auto-generated code.
  - Custom Message – Print “I’m coding in [Your IDE]!”
  - Run and Rerun – Make a small change and run again.
  - IDE Shortcuts – Use at least 2 shortcuts (e.g., run, format code).
 - *Comments*
   - *I merged these small projects into one*


## Chapter 3: Hello World

### From The Book
- [x] Project 1 - Hello, World!
  - Create a new Hello World program from the C# Console Application template.
  - Run your program using any of the three methods described above.

- [x] Project 1B - What Comes Next
  - Change your program to say something besides “Hello, World!”
  - *Comments*
    - *I don't create a new project for this, I update project 1*    

- [x] Project 2 - The Makings of a Programmer
  - Make a program with 5 Console.WriteLine statements in it.
  - Answer this question: How many statements do you think a program can contain?

- [x] Project 3 - Consolas and Telim
    - Telim will share his bread with the city if you can build a program that lets him enter the names of those receiving it. A sample run of this program looks like this:
      ```
      Bread is ready.
      Who is the bread for?
      RB
      Noted: RB got bread.
      ``` 
    - Make a program that runs as shown above, including taking a name from the user.

### From ChatGPT
- [x] Project 4 
  - Custom Greeting – Ask for user’s name and greet them.
  - Two-Line Output – Print your name and favorite color.
  - Hello in Multiple Cases – Output upper/lower/mixed case.
  - Input-Output – Read user name, then say “Nice to meet you, [name]!”


## Chapter 4: Comments

### From the book
- [x] Project 1 - The Thing Namer 3000
  - Rebuild the following program
    ```
    Console.WriteLine("What kind of thing are we talking about?");
    string a = Console.ReadLine();
    Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
    string b = Console.ReadLine();
    string c = "of Doom";
    string d = "3000";
    Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
    ```
  - Add comments near each of the four variables that describe what they store. You must use at least
one of each comment type (// and /* */).
  - Find the bug in the text displayed and fix it.
  - Answer this question: Aside from comments, what else could you do to make this code more
understandable?


### From ChatGPT
- [x] Project 2
    - Add Line Comments – Explain each line of a simple program.
    - Block Comment – Wrap a paragraph in /* */.
    - Comment Joke – Write a short program that explains itself humorously.
    - Comment Plan – Write only comments to describe a future program.
    - Debug Notes – Comment areas to fix or improve.

    
Chapter 5: Variables
    1. Store and Print – Store your age, name, and city in variables and print them.
    2. Swap Variables – Swap two variables and print the result.
    3. Travel Budget – Calculate total trip cost with basic math.
    4. Hobby Info – Store details about a hobby and output them.
    5. Temperature Converter – Convert Celsius to Fahrenheit.

Chapter 6: The C# Type System
    1. Practice Types – Declare and print each basic type.
    2. Type Conversion – Convert string to int and perform addition.
    3. Character Codes – Print a few char values and their Unicode codes.
    4. Type Summary – Print the size of each basic numeric type.
    5. Type Check – Use GetType() to confirm data types.

Chapter 7: Math
    1. Age Calculator – Ask for birth year and compute current age.
    2. Area of Circle – Prompt radius and compute area.
    3. Tip Calculator – Ask for bill and tip percentage.
    4. Average Finder – Ask for 3 numbers, compute average.
    5. BMI Calculator – Ask for height and weight, then compute BMI.

Chapter 8: Console 2.0
    1. Text Aligner – Align three labels using spacing.
    2. Color Preview – Let user choose a foreground color.
    3. Inventory Table – Display items and prices in a table.
    4. Styled Greeting – Print a centered greeting using padding.
    5. Typewriter Effect – Display a sentence character-by-character.

Chapter 9: Decision Making (if/else)
    1. Even or Odd – Check if number is even.
    2. Grade Checker – Return letter grade from score.
    3. Voting Eligibility – Ask age, confirm if allowed to vote.
    4. Number Range – Check if number is in range 1–100.
    5. Password Gate – Prompt and validate secret password.

Chapter 10: Switches
    1. Day of Week – Input day, return activity.
    2. Mood Responder – Choose a mood and respond.
    3. Vending Machine – Select item from menu and show cost.
    4. Grade Feedback – Use switch to give grade feedback.
    5. Command Handler – Accept command strings and switch on them.

Chapter 11: Looping
    1. Count Down – From 10 to 1.
    2. Sum Until Zero – Sum inputs until 0 is entered.
    3. Retry Login – Allow 3 attempts to enter password.
    4. Multiplication Table – Show a table 1–10.
    5. Number Guess – Guess a random number with hints.

Chapter 12: Arrays
    1. Store 5 Numbers – Save and print them.
    2. Reverse Array – Print an array backwards.
    3. Find Maximum – Show largest number.
    4. Search Array – Find if a value exists.
    5. Grades Average – Store grades, compute average and pass/fail.

Chapter 13: Methods
    1. Simple Adder – Create and call an Add() method.
    2. Greeting Method – Pass a name and return a greeting.
    3. Temperature Converter – Create method to convert Fahrenheit to Celsius.
    4. Max Method – Return the greater of two numbers.
    5. Factorial – Compute using recursion.


    Project 1: Character Sheet Builder
Topics Covered: Variables, Types, Console I/O, Methods, Conditionals, Properties
Overview:
Create a program that asks the user for character details (name, age, class, stats), calculates derived values (e.g., attack power), and prints a formatted character sheet.
Core Features:
    • Input: string, int, double
    • Method for computing AttackRating()
    • Validation (e.g., stat total must not exceed 100)
    • Use of properties with validation
    • Enum for class types (Warrior, Mage, Rogue)
Start After:
    • Chapter 6 (Type System)
    • Chapter 7 (Math)
    • Chapter 13 (Methods)
 You’ll need:
    • Basic input/output
    • Variables and types
    • Simple calculations and encapsulation


Chapter 14: Memory Management
    1. Stack vs Heap – Comment and simulate value vs reference types.
    2. Ref Tester – Show a class being modified through a method.
    3. Object Lifetime – Create objects in a method and monitor scope.
    4. Change Tracker – Log changes to objects passed by reference.
    5. Recursive Crash – Create a runaway recursive method (and explain why it fails).

