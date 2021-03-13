using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Derek Peacock 14/12/2020
    /// </summary>
    public static class Program
    {
        public static DistanceConverter converter = new DistanceConverter();

        public static BMI calculator = new BMI();

        public static StudentMarks Marks = new StudentMarks();
        public static void Main(string[] args)
        {
            // Starts application in the color yellow
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            //Outputs the heading using parameters set
            ConsoleHelper.OutputHeading("BNU CO453 Applications Programming 2020-2021!");

            // Lists choices as an array using variables inputed 
            string[] choices = { "Distance Converter", "BMI Calculator", "Student Marks" };

            // Selects a number equivalent to the array 
            int choiceNo = ConsoleHelper.SelectChoice("Select a choice"
                ,choices);

            // If the number equals a choice listed, it opens a program
            // If else then Invalid entry
            if (choiceNo == 1)
            {
                converter.ConvertDistance();
            }
            else if (choiceNo == 2)
            {
                calculator.calculator();
            }
            else if (choiceNo == 3)
            {
                
                Marks.RunGradesApp();
            }
            else Console.WriteLine("Invalid Entry!");

        }
    }
}
