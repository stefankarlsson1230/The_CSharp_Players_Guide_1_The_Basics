Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine();  // The thing we are talking about
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine();  // Our description of the thing
string c = "Doom";   /*  c stores the string "of Doom". I also removed an unneccesary "of" */
string d = "3000";      /*  d stores the string "3000" */
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");


// Answer this question: Aside from comments, what else could you do to make this code more understandable?
// More descriptive variable names
