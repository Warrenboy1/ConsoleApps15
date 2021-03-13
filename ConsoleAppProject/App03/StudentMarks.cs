using System;
using System.Collections.Generic;
using YamlDotNet.Core;

namespace ConsoleAppProject.App03
{
    public class StudentMarks
    {

        public List<Student> Students = new List<Student>() /*= FileConfig.ReadFromBinaryFile(FileConfig.directory1)*/
        {
            new Student() { ID=2174321, FirstName="Bob", LastName="Somebode", Grade=0, Mark=45},
            new Student() { ID=4276132, FirstName="Warren", LastName="Frank-Da"},
            new Student() { ID=8312893, FirstName="Albert", LastName="CoolGuyssss"},
            new Student() { ID=3132344, FirstName="Nerizza", LastName="GenshinE"},
            new Student() { ID=1354363, FirstName="Andrei", LastName="SmartGuyy"}

        };

        public string[] Choices = new string[]
        {
                "Add New Student",
                "Display List of Students With Marks & Grade",
                "Display Students obtaining a certain grade",
                "Input Marks",
                "Calculate Mean, Minimum and Maximum Mark",
                "Save file and Exit",
                "Exit Without Saving"
        };

        public double StudentMean;
        public double StudentMaximum;
        public double StudentMinimum = 100;

        public int StudentLength { get; private set; }
        public int StudentTotal { get; private set; }
        public IEnumerable<int> GradeProfile { get; private set; }

        public void RunGradesApp()
        {

            // Distance Converter is output as heading
            ConsoleHelper.OutputHeading("Student Marks");
            var Exit = false;
            while (!Exit)
            {            
                Console.ForegroundColor = ConsoleColor.DarkMagenta;

               int Choice = ConsoleHelper.SelectChoice("Please choose from the list of choices ", Choices);
                /// Return /confirm the choice made alongside the description.
                /// 
                Console.ForegroundColor = ConsoleColor.Yellow;

                if (Choice == 1)
               {
                   StudentAdd();
               }
               else if (Choice == 2)
               {
                   DisplayListStudents();
               }
               else if (Choice == 3)
               {
                    var StudentTotal = 0;
                    int first = 0;
                    int second = 0;
                    int second2 = 0;
                    int third = 0;
                    int fail = 0;
                    foreach (Student student in Students)
                    {
                        student.Length = 1;
                        StudentTotal += student.Length;

                        if (student.Mark < 40)
                            fail++;
                        else if (student.Mark < 50 && student.Mark >= 40)
                            third++;
                        else if (student.Mark < 60 && student.Mark >= 50)
                            second2++;
                        else if (student.Mark < 70 && student.Mark >= 60)
                            second++;
                        else if (student.Mark >= 70)
                            first++;

                    }
                    Grades grade = Grades.X;
                    //Students.Count()
                        
                    {
                        int percentageA = first * 100 / StudentTotal;
                        int percentageB = second * 100 / StudentTotal;
                        int percentageC = second2 * 100 / StudentTotal;
                        int percentageD = third * 100 / StudentTotal;
                        int percentageF = fail * 100 / StudentTotal;

                        Console.WriteLine($"Grade {Grades.A} {percentageA}% Count {first}");
                        Console.WriteLine($"Grade {Grades.B} {percentageB}% Count {second}");
                        Console.WriteLine($"Grade {Grades.C} {percentageC}% Count {second2}");
                        Console.WriteLine($"Grade {Grades.D} {percentageD}% Count {third}");
                        Console.WriteLine($"Grade {Grades.F} {percentageF}% Count {fail}\n\n");

                        grade++;
                    }

               }
               else if (Choice == 4)
               {
                    InputMarks();
               }
               else if (Choice == 5)
               {
                    
                    foreach (Student student in Students)
                    {
                        student.Length = 1;
                        
                        if (student.Mark > student.Maximum && student.Mark > StudentMaximum) StudentMaximum = student.Mark;
                        if (student.Mark < StudentMinimum) StudentMinimum = student.Mark;
                        StudentTotal += student.Mark;

                        StudentLength += student.Length++;

                        StudentMean = StudentTotal / StudentLength;
                        //student.Mean += Mean;
                    }
                   
                    Console.WriteLine($"Mean:{ StudentMean}\tMinimum:{StudentMinimum}\tMaximum:{StudentMaximum}\n");

                }
               else if (Choice == 6)
               {
                   FileConfig.WriteToBinaryFile(FileConfig.directory1, Students);
                   Exit = true;
               }
               else if (Choice == 7)
                   Exit = true;
                
            }
            Console.WriteLine("\n");

        }

        private Grades ConvertToGrade()
        {
            foreach (Student student in Students)
            {

                if (student.Mark < 40)
                    student.Grade = Grades.F;
                

            else if (student.Mark >= 40 && student.Mark < 50)

                    student.Grade = Grades.D;

            else if (student.Mark >= 50 && student.Mark < 60)

                    student.Grade = Grades.C;

            else if (student.Mark >= 60 && student.Mark < 70)

                    student.Grade = Grades.B;

            else if (student.Mark >= 70 && student.Mark <= 100)

                    student.Grade = Grades.A;

            else student.Grade = Grades.NULL;
            }
            return Grades.X;
        }

        //private void DisplayGradeProfile()
        //{
        //    foreach (Student student in Students)
        //    {
        //        //Student.CalculateGradeProfile();

        //    }
        //    Console.WriteLine("\n");

        //}

        private void DisplayListStudents()
        {
            Console.WriteLine($"FirstName\tLastName\t\tID\t\tGrade\t\tMark\n");

            foreach (Student student in Students)
            {
                Console.WriteLine($"{student.FirstName}\t\t{student.LastName}\t\t{student.ID}\t\t{student.Grade}\t\t{student.Mark}");
            }
            Console.WriteLine("\n");

        }

        public void StudentAdd()
        {

            var FirstName = ConsoleHelper.InputString("\tEnter the First Name of student > ");
            //CheckName(ConsoleHelper.InputString(FirstName));

            Student student = new Student();

            if (CheckName(FirstName) == null)
            {
                Console.Write("\tAdding new Student");

                student.FirstName = FirstName;
                student.LastName = ConsoleHelper.InputString("\n\tEnter the Last Name of student > ");
                student.ID = (int)ConsoleHelper.InputNumber("\n\tEnter the ID of the student > ");

                Students.Add(student);

                string added = $"\tStudent: {student.FirstName} {student.LastName} with ID: {student.ID} has been added.\n";
                Console.WriteLine(added);

            }
            else
            {
                Console.WriteLine("Student is already added");

                Console.WriteLine("Is that a valid name?");
            }
            Console.WriteLine("\n");


        }
        public void InputMarks()
        {
            var FirstName = ConsoleHelper.InputString("\tEnter the First Name of student > ");

            Student student = CheckName(FirstName);
            {
                if (Students != null)
                {
                    student.Mark = Convert.ToInt32(ConsoleHelper.InputNumber($"Enter the Mark for {FirstName}", 1, 100));
                    student.Grade = student.ConvertToGrade(student.Mark);
                }
            }
            Console.WriteLine("\n");

        }

        public Student CheckName(string FirstName)
        {
            foreach (Student Student in Students)
            {
                
                if (Student.FirstName == FirstName)
                {
                    return Student;
                }
                
            }
            return null;
        }

    } 
}
