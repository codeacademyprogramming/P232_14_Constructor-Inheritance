using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Human
    {
        public Human(string name)
        {
            this.Name = name;
        }
        public Human(string name,string surname)
        {
            Surname = surname;
            Name = name;
        }



        public string Name;
        public string Surname;
        public byte Age = 15;
    }
}
