using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class TaxiService
    {
        public TaxiService()
        {
            UtworzDzielnice();
            Utworztaksowki();

        }
        
        private void UtworzDzielnice()
        {
            Dzielnice.Add(new District(1, "Retkinia", -2));
            Dzielnice.Add(new District(2, "Łódź Kaliska", -1));
            Dzielnice.Add(new District(3, "Śródmieście", 0));
            Dzielnice.Add(new District(4, "Widzew", 1));
            Dzielnice.Add(new District(5, "Janów", 5));
            
        }
        private void Utworztaksowki()
        {
            Taksowki.Add(new Cab(1, "Ford Mondeo", Dzielnice[0]));
            Taksowki.Add(new Cab(2, "Dacia Logan", Dzielnice[1]));
            Taksowki.Add(new Cab(3, "Toyota Avensis", Dzielnice[2]));
            Taksowki.Add(new Cab(4, "Mercedes E220", Dzielnice[3]));
            Taksowki.Add(new Cab(5, "Huindai Lantra", Dzielnice[4]));
        }
        public List<District> Dzielnice { get; set; } = new List<District>();
        public List<Cab> Taksowki { get; set; } = new List<Cab>();
    }
}
