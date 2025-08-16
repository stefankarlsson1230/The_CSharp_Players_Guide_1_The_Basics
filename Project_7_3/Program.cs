//  Create a program that allows users to enter how many provinces, duchies, and estates they have.
//  Add up the user’s total score, giving 1 point per estate, 3 per duchy, and 6 per province.
//  Display the point total to the user.

Write("Provinces: ");
int provinces = int.Parse(ReadLine());

Write("Dutchies: ");
int duchies = int.Parse(ReadLine());

Write("Estates: ");
int estates = int.Parse(ReadLine());

WriteLine("Total points: " + (provinces * 6 + duchies * 3 + estates));

