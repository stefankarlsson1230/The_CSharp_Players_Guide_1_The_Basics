//Story:
//  The city is arranged in blocks, numbered like a chessboard.
//  The city’s only defense is a movable magical barrier, operated by a squad of four that can protect a single city block by putting themselves in each of the target’s four adjacent blocks. For example, to protect the city block at (Row 6, Column 5), the crew deploys themselves to (Row 6, Column 4), (Row 5, Column 5), (Row 6, Column 6), and (Row7, Column 5).
//  The City of Consolas needs a program to tell the squad where to deploy, given the anticipated target. Something like this:
//      Target Row? 6
//      Target Column? 5
//      Deploy to:
//      (6, 4)
//      (5, 5)
//      (6, 6)
//      (7, 5)
//Objectives:
//  Ask the user for the target row and column.
//  Compute the neighboring rows and columns of where to deploy the squad.
//  Display the deployment instructions in a different color of your choosing.
//  Change the window title to be “Defense of Consolas”.
//  Play a sound with Console.Beep when the results have been computed and displayed.

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Title = "Defense of Consolas";

Write("Target Row? ");
int row = int.Parse(ReadLine());

Write("Target Column? ");
int column = int.Parse(ReadLine());

WriteLine("Deploy to:");
WriteLine($"({row}, {column - 1})");
WriteLine($"({row - 1}, {column})");
WriteLine($"({row}, {column + 1})");
WriteLine($"({row + 1}, {column})");

Console.Beep(500, 1000);
