using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Vehicle
    {
        public string Brand;
        public string Model;
        public int Year;

        public Vehicle()
        {

        }

        public Vehicle(string brand,string model,int year)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
        }
    }
}
