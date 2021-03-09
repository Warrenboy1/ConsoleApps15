using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App03
{
    public class StudentGrades
    {
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }


        public StudentGrades()
        {
            Students = new string[]
            {
                "Albert", "Aaron", "Frank", "Hedley", "Dawn", "Daniel", "Michael", "Gabrielle", "Andrei", "Nerizza", "Nat"
            };

            GradeProfile = new int[(int)StudentMarks.Grades.A + 1];
            Marks = new int[Students.Length];
        }
    }
}
