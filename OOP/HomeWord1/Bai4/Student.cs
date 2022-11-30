using System;
using System.Collections.Generic;
using System.Text;

namespace Bai4
{
    public class Student
    {
        private string program;
        private int year;
        private double score;
        private string name;
        private string address;

        public Student(string program, int year, double score, string name, string address)
        {
            this.Program = program;
            this.Year = year;
            this.Score = score;
            this.name = name;
            this.address = address;
        }

        public string Program { get => program; set => program = value; }
        public int Year { get => year; set => year = value; }
        public double Score { get => score; set => score = value; }

    }
}
