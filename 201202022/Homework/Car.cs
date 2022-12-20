using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Car
    {
        public string Brand;
        public string Model;
        public int CurrentFuel;
        public int FuelFor1Km;
        public int Millage;

        public void Drive(int km)
        {
            if (CurrentFuel / FuelFor1Km >= km)
            {
                Millage += km;
                CurrentFuel -= km * FuelFor1Km;
            }
            else
                Console.WriteLine("Xeta");
        }
    }
}
