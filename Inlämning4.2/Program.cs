using System;
using System.Diagnostics.SymbolStore;

namespace Inlämning_4.__2
{
    class Program
    {
        static void Main(string[] args)
        {
            int highTal = 0;
            while (true)
            {
                Console.WriteLine("Vill du skriva in ett heltal ja eller nej");
                string svar = Console.ReadLine();
                if (svar == "nej")
                {
                    break;
                }

                Console.WriteLine("Skriv in ett heltal");
                int diTal = int.Parse(Console.ReadLine());
                if (diTal > highTal)
                {
                    highTal = diTal;
                }

            }
            Console.WriteLine("Det största talet var: "+highTal);
        }
    }
}