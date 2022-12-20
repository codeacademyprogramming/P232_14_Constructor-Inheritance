using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Student:Human
    {
        public Student(string name):base(name)
        {

        }

        public Student(string name,string surname) : base(name, surname)
        {

        }

        public string GroupNo;
        public int AvgPoint;
    }
}
