using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Notebook
    {
        public string Name;
        public string BrandName;
        public double Price;

        public string GetInfo()
        {
            return $"Name: {Name} - Brand: {BrandName} - Price: {Price}";
        }
    }
}
