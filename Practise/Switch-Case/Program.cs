void Sample1()
{
    Console.Write("Enter Username: ");
    string userName = Console.ReadLine();

    if (userName == "Admin")
    {
        Console.WriteLine("Welcome To Admin Panel");
    }

    else if (userName == "User")
    {
        Console.WriteLine("Welcome To User Panel");
    }

    else
    {
        Console.WriteLine("You have logged in incorrectly!");
    }
}

void Sample2()
{
    Console.Write("Enter Username: ");
    string userName = Console.ReadLine();

    switch (userName)
    {
        case "Admin":
            {
                Console.WriteLine("Welcome To Admin Panel");
                break;
            }
        case "User":
            {
                Console.WriteLine("Welcome To User Panel");
                break;
            }
        default:
            {
                Console.WriteLine("You have logged in incorrectly!");
                break;
            }
    }
}

void Sample3()
{
    Console.Write("Enter note: ");
    int note = int.Parse(Console.ReadLine());

    switch (note)
    {
        case >= 0 and < 100:
            {
                switch (note)
                {
                    case <= 30:
                        {
                            Console.WriteLine("FF");
                            break;
                        }
                    case <= 50:
                        {
                            Console.WriteLine("DD");
                            break;
                        }
                    case <= 70:
                        {
                            Console.WriteLine("CC");
                            break;
                        }
                    case <= 84:
                        {
                            Console.WriteLine("BB");
                            break;
                        }
                    case <= 100:
                        {
                            Console.WriteLine("AA");
                            break;
                        }
                }
                break;
            }
        default:
            {
                Console.WriteLine("You have logged in incorrectly!");
                break;
            }
    }
}


void Sample4()
{
    Console.Write("Write color: ");
    string color = Console.ReadLine();

    switch (color)
    {
        case "Siyah":
            {
                Console.WriteLine("Black");
                break;
            }
        case "Kirmizi":
            {
                Console.WriteLine("Red");
                break;
            }
        case "Yesil":
            {
                Console.WriteLine("Green");
                break;
            }
        case "Pembe":
            {
                Console.WriteLine("Pink");
                break;
            }
            default:
            {
                Console.WriteLine("Error");
                break;
            }
    }

    string result = color switch
    {
        "Siyah" => "Black",
        "Pembe" => "Pink",
        _ => "Error"
    };
    Console.WriteLine(result);
}

