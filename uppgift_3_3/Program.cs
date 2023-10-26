using System;

class Program
{
    static void Main()
    {
        int maxHyraPerDag = 950;
        int timpris = 80;

        Console.Write("Hur många timmar vill du hyra bilen: ");
        int antalTimmar = int.Parse(Console.ReadLine());

        if (antalTimmar <= 0)
        {
            Console.WriteLine("Du måste hyra bilen i minst en timme.");
        }
        else if (antalTimmar * timpris <= maxHyraPerDag)
        {
            int kostnad = antalTimmar * timpris;
            Console.WriteLine("Kostnaden för att hyra bilen i " + antalTimmar + " timmar är " + kostnad + " kr.");
        }
        else
        {
            Console.WriteLine("Du kan inte hyra bilen i så många timmar eftersom maxhyran per dag är 950 kr.");
        }
    }
}