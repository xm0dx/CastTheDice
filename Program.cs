using System;

namespace CastTheDice;

class Program
{
    static readonly Random random = new();

    static void Main()
    {
        Console.WriteLine("Välkommen till Kasta tärningarna!");
        Console.WriteLine("Du kastar två tärningar. Blir summan 12 vinner du.");

        while (true)
        {
            // tre punkter med en liten paus innan resultatet visas
            Console.Write("Tärningarna kastas");
            for (int i = 0; i < 3; i++) // LOOP
            {
                Thread.Sleep(500); //paus
                Console.Write(".");
            }
            Console.WriteLine();

            // Next(1, 7) ger ett tal från 1 till 6, 7 räknas inte med
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int sum = dice1 + dice2;

            Console.WriteLine($"Du fick {dice1} och {dice2}. Summan blev {sum}.");

            if (sum == 12)
            {
                // ändrar färgen på texten till grön på terminalen finns på .NET dokumentationen
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Grattis, du vann!");
                Console.ResetColor();
                break;
            }

            Console.WriteLine("Vill du spela igen? j/n");
            var answer = Console.ReadLine();

            // allt annat än j avslutar spelet
            if (answer != "j")
            {
                Console.WriteLine("Spelet avslutas.");
                break; // avs loopen
            }
        }
    }
}
