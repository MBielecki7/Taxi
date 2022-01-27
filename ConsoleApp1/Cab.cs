using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Cab
    {
        public Cab(int id, string name, District district)
        {
            Id = id;
            Name = name;
            AktualnaDzielnica = district;
            IsAvailable = true;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAvailable { get; set; }
        public District AktualnaDzielnica { get; set; }
        public int Time { get; set; }
        public string Status
        {
            get
            {
                return IsAvailable ? "WOLNY" : "ZAJĘTY";
            }
        }
        public void CalculateTime(District dzielnicaWezwanie)
        {
            if (dzielnicaWezwanie.Number == AktualnaDzielnica.Number)
            {
                if (IsAvailable)
                {
                    Time = 4;

                }
                else
                {
                    Time = 4 + 12;
                }
            }
            else
            {
                int trasa = Math.Abs(dzielnicaWezwanie.DistanceFromCentrum - AktualnaDzielnica.DistanceFromCentrum);
                if (IsAvailable)
                {
                    Time = 5 * trasa;
                }
                else
                {
                    Time = 5 * trasa + 12;
                }
                
            }
          
        }
       
        
        
        
       

    }
}
