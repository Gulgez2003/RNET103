using System.Linq.Expressions;

//void Sample1()
//{
//    Console.Write("Enter your phone number: ");
//    int number = int.Parse(Console.ReadLine());
//    Console.WriteLine($"You entered: { number}");
//}

void Sample2()
{
    try
    {
        Console.Write("Enter your phone number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"You entered: {number}");
    }
    catch
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("Error");
        Console.ResetColor();
    }
}

Sample2();