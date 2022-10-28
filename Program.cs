

// Välkomnande meddelande
// En lista för att spara historik för räkningar
// Användaren matar in tal och matematiska operation
//OBS! Användaren måsta mata in ett tal för att kunna ta sig vidare i programmet!
// Ifall användaren skulle dela 0 med 0 visa Ogiltig inmatning!
// Lägga resultat till listan
//Visa resultat
//Fråga användaren om den vill visa tidigare resultat.
//Visa tidigare resultat
//Fråga användaren om den vill avsluta eller fortsätta.

Console.WriteLine("Mortezas miniräknare");

List<String> Historik = new List<String>();

while (true)
{
    Console.WriteLine(" ");

    Console.WriteLine("Välj operation: ");
    Console.WriteLine("A: Addition");
    Console.WriteLine("B: Subtration");
    Console.WriteLine("C: Division");
    Console.WriteLine("D: Multiplikation");
    Console.WriteLine("E: Skriv ut historik");
    Console.WriteLine("F: För att avsluta");

    Console.WriteLine(" ");
    String Operation = Console.ReadLine();
    Console.WriteLine(" ");


    if (Operation == "F" || Operation == "f")
    {
        Console.WriteLine("Hejdå, Tryck enter för att stänga konsol");
        Environment.Exit(0);
    }


    if (Operation == "E" || Operation == "e")
    {
        foreach (String S in Historik)
        {
            Console.WriteLine("Historik: " + S);

        }
    }
    else if (!(Operation.ToLower() == "f" || Operation.ToLower() == "a" || Operation.ToLower() == "b" || Operation.ToLower() == "c" || Operation.ToLower() == "d" || Operation.ToLower() == "e"))
    {
        Console.WriteLine("Ogiltig inmatning");
    }
    else
    {
        Console.WriteLine("Mata in första siffran");
        int siffra1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Mata in andra siffran");
        int siffra2 = Convert.ToInt32(Console.ReadLine());

        if (Operation == "A" || Operation == "a")
        {
            int Summa = siffra1 + siffra2;

            Console.WriteLine(siffra1 + "+" + siffra2 + "=" + Summa);
            String Spara = (siffra1 + "+" + siffra2 + "=" + Summa);

            Historik.Add(Spara);
        }

        else if (Operation == "B" || Operation == "b")
        {
            int Differens = siffra1 - siffra2;

            Console.WriteLine(siffra1 + "-" + siffra2 + "=" + Differens);
            String Spara = (siffra1 + "-" + siffra2 + "=" + Differens);

            Historik.Add(Spara);
        }
        else if (Operation == "C" || Operation == "c")
        {

            try
            {
                int Kvot = siffra1 / siffra2;
                Console.WriteLine(siffra1 + "/" + siffra2 + "=" + Kvot);
                String Spara = (siffra1 + "/" + siffra2 + "=" + Kvot);
                Historik.Add(Spara);
            }
            catch (Exception)
            {
                Console.WriteLine("NEJ, DET GåR INTE ATT DELA MED NOLL");
            }
        }


        else if (Operation == "D" || Operation == "d")
        {
            int Produkt = siffra1 * siffra2;

            Console.WriteLine(siffra1 + "*" + siffra2 + "=" + Produkt);
            String Spara = (siffra1 + "*" + siffra2 + "=" + Produkt);

            Historik.Add(Spara);


        }


    }




}
