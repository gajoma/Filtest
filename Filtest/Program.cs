using System;
using System.IO; //Skal tilføjes!
namespace Filtest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            String path = @"tekstfil.txt"; //Filen skal placeres i: Source/Repos/Filtest/Filtest/bin/Debug/net5.0
            String[] tekst = File.ReadAllLines(path); //Alle filens linjer indlæses i Array'et 'tekst'
            for (int i = 0; i < tekst.Length; i++) 
            {
                Console.WriteLine(tekst[i]); //De enkelte linjer udskrives, en for en.
            }
            Console.ReadKey();
            while (true) //Udskrivning af en tilfældig linje:
            {
                int linje = rnd.Next(0, tekst.Length);
                Console.WriteLine();
                Console.WriteLine(tekst[linje]);

                Console.ReadKey();

            }


        }
    }
}
