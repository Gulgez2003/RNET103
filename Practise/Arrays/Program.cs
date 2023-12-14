//string[] arabalar = new string[5] { "Audi", "Mercedes", "Jeep", "Hundai", "Toyota" };
//Console.WriteLine(arabalar[new Random().Next(0, arabalar.Length)]);

string word = Console.ReadLine();

int count = 1;

for (int i = 0; i < word.Length-1; i++)
{

    if (word[i] == word[i + 1])
    {
        count++;
    }
    Console.WriteLine($"{word[i]}->{count}");
}

