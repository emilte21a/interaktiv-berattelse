Console.WriteLine("Hej, vad är ditt namn?");

string namn = Console.ReadLine();

if (namn == "theo")
{
    Console.WriteLine("är du konstig?");


    string val = Console.ReadLine();

    if (val == "ja")
    {
        Console.WriteLine("hoppas du har en dålig dag Theo");
        namn = "theo";

    }

    else if (val != "ja")
    {
        Console.WriteLine("Okej bra...");

        Console.WriteLine("Men seriöst, vad heter du?");

        namn = Console.ReadLine();

    }
}

if (namn == "richard")
{
    Console.WriteLine("är du drainer?");


    string val = Console.ReadLine();

    if (val == "ja")
    {
        Console.WriteLine("ecco2k fell off");
        namn = "richard";

    }

    else if (val != "ja")
    {
        Console.WriteLine("Okej vad bra!");

        namn = "richard";

    }
}

if (namn == "emil")
{
    Console.WriteLine("Om du verkligen är emil...gillar du cola zero mer än normal cola?");


    string val = Console.ReadLine();

    if (val == "ja")
    {
        Console.WriteLine($"bra där!!!");


    }

    else if (val != "ja")
    {
        Console.WriteLine("Okej.. Du är falsk");
        namn = "noname";
        Console.WriteLine("Men seriöst, vad heter du?");

        namn = Console.ReadLine();

    }
}






if (namn == "theo")
{
    Console.WriteLine("Tryck ENTER för att avsluta");
}


else
{


    Console.WriteLine($"Hoppas du har en fin dag {namn}.");

    Console.WriteLine("Tryck ENTER för att avsluta");


}


Console.ReadLine();
