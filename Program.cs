using System;

public class Program
{
    static string tekst1 = "Statisk string";
    string tekst2 = "Ikke statisk string";

    public static void Main()
    {

        Console.WriteLine(tekst1); // Denne string kan godt udskrives, da det er en statisk string
     // Console.WriteLine(tekst2); // Denne string kan ikke udskrives, da en statisk metode ikke kan tage imod ikke statiske variabler
     //Error: CS0120 - An object reference is required for the nonstatic field, method, or property 'member'

        statiskMetodeTekst("Den statiske metode tekst"); // Denne metode kan godt udskrives da metoden er statisk
     // ikkeStatiskMetodeTekst("Den ikke statiske metode tekst"); // Denne metode kan ikke udskrives da metoden ikke er statisk og kan derfor ikke tilgås
     //Error: CS0120 - An object reference is required for the nonstatic field, method, or property 'member'
     
     // En statisk metode kan kun kalde på andre statiske metoder og variabler. Man kan ikke få adgang til ikke statiske metoder og variabler.



        var result = Lommeregner.Sum(5, 195); // Dette kalder en statisk metode og giver værdier som er krævet i arguments
        Lommeregner.Resultatet(result);
        Console.WriteLine(result);

        var mærke = Lommeregner.Type; // Henter typen som først er angivet i metoden.
        Console.WriteLine($"Mærke: {mærke}");

        Lommeregner.Type = "Casio"; // Ændrer typen som er angivet i metoden
        var mærke2 = Lommeregner.Type; // Henter den nye metode som er angivet ovenover
        Console.WriteLine($"Mærke ændret til: {mærke2}");
    }
    static public void statiskMetodeTekst(string statiskTekst)
    {
        Console.WriteLine(statiskTekst);
    }
    public void ikkeStatiskMetodeTekst(string ikkeStatiskTekst)
    {
        Console.WriteLine(ikkeStatiskTekst);
    }
}

public static class Lommeregner
{
    private static int Resultat = 0;

    public static string Type = "Texas Instruments";

    public static int Sum(int førsteNummer, int andetNummer)
    {
        return førsteNummer + andetNummer;
    }

    public static void Resultatet(int result)
    {
        Resultat = result;
    }
}
