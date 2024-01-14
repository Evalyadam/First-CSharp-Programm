
Console.WriteLine("Enter Username:");
string Username = Console.ReadLine();
Console.WriteLine("Enter Password:");
string Password = Console.ReadLine();
/*This code asks the user for theyre
 Username and Password using 'ReadLine' in varaiables.*/


Random random = new Random();

int UserID = random.Next(1, 1001);

Console.WriteLine(UserID);