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

    
## Chapter 5: Variables

### From ChatGPT
- [x] Project 1
  - Store and Print – Store your age, name, and city in variables and print them.
  - Swap Variables – Swap two variables and print the result.
  - Travel Budget – Calculate total trip cost with basic math.
  - Hobby Info – Store details about a hobby and output them.
  - Temperature Converter – Convert Celsius to Fahrenheit.

  
## Chapter 6: The C# Type System

### From The Book
- [x] Project 1 - The Variable Shop + The Variable Shop Returns
  - Build a program with a variable of all fourteen types described in this level.
  - Assign each of them a value using a literal of the correct type.
  - Use Console.WriteLine to display the contents of each variable.
  - Modify your Variable Shop program to assign a new, different literal value to 
    each of the 14 original variables. Do not declare any additional variables.
  - Use Console.WriteLine to display the updated contents of each variable. 
  
### From chatGPT
- [x] Project 2
    - Type Conversion – Convert string to int and perform addition.
    - Character Codes – Print a few char values and their Unicode codes.
    - Type Summary – Print the size of each basic numeric type.
    - Type Check – Use GetType() to confirm data types.

    
## Chapter 7: Math

### From The Book
- [x] Project 1 - The Triangle Farmer
  - Write a program that lets you input the triangle’s base size and height.
  - Compute the area of a triangle by turning the above equation into code.
  - Write the result of the computation.
  - Area = (base x height) / 2

- [x] Project 2 - The Four Sisters and the Duckbear
  - Create a program that lets the user enter the number of chocolate eggs gathered that day.
  - Using / and %, compute how many eggs each sister should get and how many are left over for the
duckbear.
  - Answer this question: What are three total egg counts where the duckbear gets more than each
sister does? You can use the program you created to help you find the answer.

- [x] Project 3 - The Dominion of Kings
  - Create a program that allows users to enter how many provinces, duchies, and estates they have.
  - Add up the user’s total score, giving 1 point per estate, 3 per duchy, and 6 per province.
  - Display the point total to the user.

### From ChatGPT
- [x] Project 4 - Age Calculator
  - Ask for birth year and compute current age.
    
- [x] Project 5 - Area of Circle 
    - Prompt radius for a circle and compute area.
 
- [x] Project 6 - Tip Calculator 
    - Ask for bill and tip percentage.

- [x] Project 7 - Average Finder
  - Ask for 3 numbers, compute average. 

- [x] Project 8 - BMI Calculator
  - Ask for height and weight, then compute BMI. 
  

## Chapter 8: Console 2.0

### The Book
- [x] Project 1 - The Defense of Consolas
    - Story:
      - The city is arranged in blocks, numbered like a chessboard.
      - The city’s only defense is a movable magical barrier, operated by a squad of four that can protect a single city block by putting
themselves in each of the target’s four adjacent blocks. For example, to protect the city block at (Row 6, Column 5), the
crew deploys themselves to (Row 6, Column 4), (Row 5, Column 5), (Row 6, Column 6), and (Row7, Column 5).
      - The City of Consolas needs a program to tell the squad where to deploy, given the anticipated
target. Something like this:
        ```
        Target Row? 6
        Target Column? 5
        Deploy to:
        (6, 4)
        (5, 5)
        (6, 6)
        (7, 5)
        ```
    - Objectives:
      - Ask the user for the target row and column.
      - Compute the neighboring rows and columns of where to deploy the squad.
      - Display the deployment instructions in a different color of your choosing.
      - Change the window title to be “Defense of Consolas”.
      - Play a sound with Console.Beep when the results have been computed and displayed.

### From ChatGPT
- [x] Project 2 - Text Aligner
  - Align three labels using spacing.

- [x] Project 3 - Color Preview
  - Let user choose a foreground color.

- [x] Project 4 - Inventory Table
  - Display items and prices in a table.

- [x] Project 5 - Styled Greeting
  - Print a centered greeting using padding.
    
- [x] Project 6 - Typewriter Effect
  - Display a sentence character-by-character.



## Chapter 9: Decision Making (if/else)

### From The Book
- [x] Project 1 - Repairing the Clocktower
  - Take a number as input from the console.
  - Display the word “Tick” if the number is even. Display the word “Tock” if the number is odd.
  - Hint: Remember that you can use the remainder operator to determine if a number is even or odd.

- [x] Project 2 - Watchtower
  - Ask the user for an x value and a y value. These are coordinates of the enemy relative to the watchtower’s location.
  - Using the image below, if statements, and relational operators, display a message about what direction the enemy is
coming from. For example, “The enemy is to the northwest!” or “The enemy is here!”
  ![image for watchtower assignment](/images/watchtower.png)

### From ChatGPT

- [x] Project 3 - Grade Checker
  - Return letter grade from score.
  
- [x] Project 4 - Voting Eligibility
  - Ask age, confirm if allowed to vote.

- [x] Project 5 - Number Range
  - Check if number is in range 1–100.
 
- [x] Project 6 - Password Gate
  - Prompt and validate secret password.


## Chapter 10: Switches

### From The Book

- [x] Project 1 - Buying Inventory
  - Build something to report the prices of various pieces of equipment based on the user’s selection:
The following items are available:
    ```
    1 – Rope
    2 – Torches
    3 – Climbing Equipment
    4 – Clean Water
    5 – Machete
    6 – Canoe
    7 – Food Supplies
    What number do you want to see the price of? 2
    Torches cost 15 gold.
    ```
  - Prices: Rope: 10 gold, Torches:
16 gold, Climbing Equipment: 24 gold, Clean Water: 2 gold, Machete: 20 gold, Canoe: 200 gold, Food
Supplies: 2 gold.
  - Build a program that will show the menu illustrated above.
  - Ask the user to enter a number from the menu.
  - Using the information above, use a switch (either type) to show the item’s cost.

- [x] Project 2 - Discounted Inventory
  - Modify your program from before to also ask the user for their name.
  - If their name equals your name, divide the cost in half.


## Chapter 11: Looping

### From The Book
- [x] Project 1 - The Prototype
  - Build a program that will allow a user to enter a number.
  - If the number is above 100 or less than 0, keep asking.
  - Clear the screen once the program has collected a good number.
  - Ask a second user to guess numbers.
  - Indicate whether the user guessed too high, too low, or guessed right.
  - Loop until they get it right, then end the program.
  - Sample Program:
    ```
        User 1, enter a number between 0 and 100: 27
    ```
     - After entering this number, the program should clear the screen and continue like this:
    ```
    User 2, guess the number.
    What is your next guess? 50
    50 is too high.
    What is your next guess? 25
    25 is too low.
    What is your next guess? 27
    You guessed the number!
    ```
- [x] Project 2 - The Magic Cannon
  - Story:
    - Skorin, a member of Consolas’s wall guard, has constructed a magic cannon that draws power from two
gems: a fire gem and an electric gem. Every third turn of a crank, the fire gem activates, and the cannon
produces a fire blast. The electric gem activates every fifth turn of the crank, and the cannon makes an
electric blast. When the two line up, it generates a potent combined blast. Skorin would like your help to
produce a program that can warn the crew about which turns of the crank will produce the different
blasts before they do it.
    - A partial output of the desired program looks like this:
        ```
        1: Normal
        2: Normal
        3: Fire
        4: Normal
        5: Electric
        6: Fire
        7: Normal
        ...
        ```
  - Objectives:
    - Write a program that will loop through the values between 1 and 100 and display what kind of blast
the crew should expect. (The % operator may be of use.)
    - Change the color of the output based on the type of blast. (For example, red for Fire, yellow for
Electric, and blue for Electric and Fire).

### From ChatGPT

- [x] Project 3 - Count Down
  - From 10 to 1.

- [x] Project 4 - Sum Until Zero
  - Sum inputs until 0 is entered.
    
- [x] Project 5 - Retry Login
  - Allow 3 attempts to enter password.
    
- [x] Project 6 - Multiplication Table
  - Show a table 1–10.


## Chapter 12: Arrays

### From The Book

- [x] Project 1 - The Replicator of D’To
  - Make a program that creates an array of length 5.
  - Ask the user for five numbers and put them in the array.
  - Make a second array of length 5.
  - Use a loop to copy the values out of the original array and into the new one.
  - Display the contents of both arrays one at a time to illustrate that the Replicator of D’To works
again.

- [x] Project 2 - The Laws of Freach
  - Start with the code for computing an array’s minimum and average values in the section Some
Examples with Arrays, starting on page 94.
  - Modify the code to use foreach loops instead of for loops.

### From ChatGPT

- [x] Project 3 - Reverse Array
  - Print an array backwards.
    
- [x] Project 4 - Find Maximum
  - Show largest number.
    
- [x] Project 5 - Search Array
  - Find if a value exists.
    
- [x] Project 6 - Grades Average
  - Store grades, compute average and pass/fail.


## Chapter 13: Methods

### From The Book
- [x] Project 1 - Taking a Number
  - Make a method with the signature int AskForNumber(string text). Display the text
parameter in the console window, get a response from the user, convert it to an int, and return it.
This might look like this: int result = AskForNumber("What is the airspeed velocity
of an unladen swallow?");.
  - Make a method with the signature int AskForNumberInRange(string text, int min, int
max). Only return if the entered number is between the min and max values. Otherwise, ask again.

- [x] Project 2 - Countdown
  - Write code that counts down from 10 to 1 using a recursive method.
  - Hint: Remember that you must have a base case that ends the recursion and that every time you
call the method recursively, you must be getting closer and closer to that base case.

### From ChatGPT

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

