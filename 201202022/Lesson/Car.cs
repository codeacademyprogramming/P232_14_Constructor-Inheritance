using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Car:Vehicle
    {
        public Car(int fuelCapacity,string brand,string model,int year):base(brand,model,year)
        {
            this.FuelCapacity = fuelCapacity;
        }

      
        public Car(int fuelCapacity)
        {
            this.FuelCapacity = fuelCapacity;
        }
        public int FuelCapacity;
    }
}
