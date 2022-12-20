using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Teacher:Human
    {
        public Teacher(string name,string surname,string subject):base(name,surname)
        {
            this.Subject = subject;
        }
        public string Subject;
    }
}
