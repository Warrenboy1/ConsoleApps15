using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App03
{
    public class StudentGrades
    {
        // Constants (Grade Boundaries)

        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        // Properties
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

        /// <summary>
        /// Input a mark between 0 - 100 for each
        /// student and store it in the Marks array
        /// </summary>
        public void InputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// List all the students and display 
        /// their name and current mark
        /// </summary>
        public void OutputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Convert a student mark to a grade from F
        /// (Fail) to A (First Class)
        /// </summary>
        public StudentMarks.Grades ConvertToGrade(int mark)
        {
            if (mark >= 0 && mark < LowestGradeD)
            {
                return StudentMarks.Grades.F;
            }
            else return StudentMarks.Grades.D;
        }

        /// <summary>
        /// Calculate and display the minimum, maximum and mean
        /// mark for all the students
        /// </summary>
        public void CalculateStats()
        {
            throw new NotImplementedException();
        }
    }
}
