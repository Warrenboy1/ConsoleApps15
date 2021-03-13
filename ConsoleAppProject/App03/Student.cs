using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ConsoleAppProject.App03
{
    [Serializable]
    public class Student
    {
        // Constants (Grade Boundaries)

        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        public Student()
        {
           
        }


        //// Properties
        //public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public int Length { get; set; }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Mark { get; set; }
        public Grades Grade { get; set; }




        //GradeProfile = new int[(int)Grades.A + 1];
        //Marks = new int[Students.Length];


        /// <summary>
        /// Input a mark between 0 - 100 for each
        /// student and store it in the Marks array
        /// </summary>


        /// <summary>
        /// List all the students and display 
        /// their name and current mark
        /// </summary>
        //public void OutputMarks()
        //{
        //    throw new NotImplementedException();
        //}

        /// <summary>
        /// Convert a student mark to a grade from F
        /// (Fail) to A (First Class)
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark < LowestGradeD)
            
               return Grades.F;
            
            else if (mark >= 40 && mark < LowestGradeC)
            
                return Grades.D;
            
            else if (mark >= 50 && mark < LowestGradeB)
            
                return Grades.C;
            
            else if (mark >= 60 && mark < LowestGradeA)
            
                return Grades.B;
            
            else if (mark >= 70 && mark <= HighestMark)
            
                return Grades.A;
            
            else return Grades.NULL;
        }
    


        /// <summary>
        /// Calculate and display the minimum, maximum and mean
        /// mark for all the students
        /// </summary>
        public void CalculateStats()
        {
            Minimum = Marks[0];
            Maximum = Marks[0];

            double total = 0;

            foreach (int mark in Marks)
            {
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;
                total += mark;
            }

        Mean = total / Marks.Length;
            Console.WriteLine($"{ Mean}     {Minimum}       {Maximum}");
        }

        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }

        OutputGradeProfile();
        }

        private void OutputGradeProfile()
        {
            Grades grade = Grades.X;
            Console.WriteLine();

            foreach (int count in GradeProfile)
        {
            int percentage = count * 100 / Marks.Length;
            Console.WriteLine($"Grade {grade} {percentage}% Count {count}");
            grade++;
        }

        Console.WriteLine();
        }
    }
    
}
