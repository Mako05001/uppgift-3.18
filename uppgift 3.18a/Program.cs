using System;
namespace uppdrag3._14
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Skriv ditt förenamn och efternamn");
            string Na = Console.ReadLine();
            int NamnIndex = Na.IndexOf(' ');
            string förenamn = Na[..NamnIndex];
            string efternamn = Na[(NamnIndex + 1)..];
            if (förenamn.CompareTo(efternamn) < 0)
            {
                Console.WriteLine("Ditt förenamn kommer före ditt efternamn i bokstavsordning");
            }
            else if (förenamn.CompareTo(efternamn) > 0)
            {
                Console.WriteLine("Ditt efternamn kommer före ditt förenamn i bokstavsordning");
            }
            else
            {
                Console.WriteLine("Ditt För och efternamn kommer på samma plat i bokstavsordning");
            }

        }
    }
}