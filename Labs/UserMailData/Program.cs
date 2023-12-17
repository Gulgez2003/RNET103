string[] names = {
  "Aaliyah",
  "Hannah",
  "Aliya",
  "Morgan",
  "Cerys",
  "Mariam",
  "Samira",
  "Amanda",
  "Sniead",
  "Claudia",
  "Mollie",
  "Caitlin",
  "Cara",
  "Jodie",
  "Alexia",
  "Lola",
  "Alicia",
  "Caitlyn",
  "Kelsey",
  "Zoe",
  "Tom",
  "Tommy",
  "Thomas",
  "Jack",
  "Harry",
  "Oliver",
  "Charlie",
  "Jacob",
  "George",
  "Oscar",
  "James",
  "William",
  "Noah",
  "Alfie",
  "Joshua",
  "Muhammad",
  "Henry",
  "Leo",
  "Archie",
  "Ethan",
  "Joseph",
  "Freddie",
  "Samuel"
};

string[] lastNames = {
    "Smith",
    "Johnson",
    "Williams",
    "Brown",
    "Jones",
    "Miller",
    "Davis",
    "Garcia",
    "Rodriguez",
    "Wilson",
    "Martinez",
    "Anderson",
    "Taylor",
    "Thomas",
    "Hernandez",
    "Moore",
    "Martin",
    "Jackson",
    "Thompson",
    "White",
    "Lopez",
    "Lee",
    "Gonzalez",
    "Harris",
    "Clark",
    "Lewis",
    "Robinson",
    "Walker",
    "Perez",
    "Hall",
    "Young",
    "Allen",
    "Sanchez",
    "Wright",
    "King",
    "Scott",
    "Green",
    "Baker",
    "Adams",
    "Nelson",
    "Hill",
    "Ramirez",
    "Campbell"
};

List<string> mailAdresleri = new();
for (int i = 0; i < 500; i++)
{
    Random rnd = new Random();
    string mail = $"{names[rnd.Next(0, names.Length)]}.{lastNames[rnd.Next(0, lastNames.Length)]}@example.com".ToLower();
    //System.Console.WriteLine(mail);
    mailAdresleri.Add(mail);
}

foreach (var mail in mailAdresleri)
{
    int firstNamePosition = mail.IndexOf(".");
    int lastNamePosition = mail.IndexOf("@");
    int mailPosition = mail.LastIndexOf(".");

    string dash = new String('-', 40);
    Console.WriteLine(
        $"{dash}" +
        $"\n- Ad        : {mail.Substring(0, firstNamePosition)}" +
        $"\n- Soyad     : {mail.Substring(firstNamePosition + 1, lastNamePosition - firstNamePosition - 1)}" +
        $"\n- Mail      : {mail}" +
        $"\n- Domain    : {mail.Substring(lastNamePosition + 1, mailPosition - lastNamePosition - 1)}" +
        $"\n- Extention : {mail.Substring(mailPosition + 1)}" +
        $"\n{dash}" +
        $"\n"
    );

}