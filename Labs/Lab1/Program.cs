Console.Write("Gelir meblegi: ");
double gelir = double.Parse(Console.ReadLine());
Console.Write("Kredit reytinqi: ");
double kredit = double.Parse(Console.ReadLine());
Console.Write("Cari borc meblegi: ");
double borc = double.Parse(Console.ReadLine());

if (gelir < 0 || kredit > 850 || kredit < 0 || borc < 0)
{
    Console.WriteLine("Duzgun melumat daxil edin.");
}
else
{
    if (gelir > 15000 && kredit > 700 && borc == 0)
    {
        double vergi = gelir switch
        {
            <= 20000 => gelir * 0.1,
            <= 50000 => gelir * 0.2,
            _ => gelir * 3
        };
        Console.WriteLine(vergi);
    }
    else
    {
        Console.WriteLine("Elave melumat teqdim edin.");
    }
}

