Console.Write("Username: ");
string username = Console.ReadLine();
Console.Write("Password: ");
string password = Console.ReadLine();

while (true)
{
    var LoginTuple = Tuple.Create(username, password);

    if (LoginTuple.Item1.Replace(" ","").Contains("Admin") && LoginTuple.Item2.Replace(" ", "").Contains("Salam123"))
    {
        Console.WriteLine("You are logged in!");
        break;
    }

    Console.WriteLine("Username or Password is incorrect, please try again");
    Console.Write("Username: ");
    username = Console.ReadLine();
    Console.Write("Password: ");
    password = Console.ReadLine();
}