using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxiService service = new TaxiService();
            Console.WriteLine("Podać Numer Dzielenicy:");
                int numerDzielnicy = int.Parse(Console.ReadLine());
            foreach (var taxi in service.Taksowki)
            {
                taxi.CalculateTime(dzielnice);
            }
        }
    }
}
