using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai3
{
    class Student
    {
        public string Id, Name, Class;
        public DateTime Birth;
        public double Score;
        public Student(string a)
        {
            Id = a;

        }
        public Student(string a, string b, string c, string d, string e)
        {
            Id = a;
            Name = b;
            Class = c;
            DateTime.TryParse(e, out Birth);
            double.TryParse(e, out Score);
        }
        public string Xuat()
        {
            return $"{Id,-10}{Name,-15}{Class,-10}{Birth.ToString("dd/MM/yy"),-15}{Score,-10}";
        }
    }
}
