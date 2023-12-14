//void Sample1()
//{
//    string userName = "Admin";
//    if (userName == "Admin")
//    {
//        Console.WriteLine("Hello Admin");
//    }
//    else
//    {
//        Console.WriteLine("You have logged in incorrectly!");
//    }
//}

//Sample1();

//void Sample2()
//{
//    int note = int.Parse(Console.ReadLine());
//    if (note >= 0 && note <= 100)
//    {
//        Console.WriteLine(note);
//    }
//    else
//    {
//        Console.WriteLine("Error");
//    }
//}

//Sample2();

void Sample3()
{
    int note = int.Parse(Console.ReadLine());
    if (note >= 0 && note <= 30)
    {
        Console.WriteLine("FF");
    }
    else if (note >= 31 && note <= 50)
    {
        Console.WriteLine("DD");
    }
    else if(note >= 51 && note <= 70)
    {
        Console.WriteLine("CC");
    }
    else if(note >= 71 && note <= 84)
    {
        Console.WriteLine("BB");
    }
    else if (note >= 85 && note <= 100)
    {
        Console.WriteLine("AA");
    }
    else
    {
        Console.WriteLine("Error");
    }
}

Sample3();
