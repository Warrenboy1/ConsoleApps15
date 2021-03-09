using System.ComponentModel;
using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// Grade A is First Class   : 70 - 100
    /// Grade B is Upper Second  : 60 - 69
    /// Grade C is Lower Second  : 50 - 59
    /// Grade D is Third Class   : 40 - 49
    /// Grade F is Fail          :  0 - 39
    /// </summary>


    public class StudentMarks
    {

        
        public string[] Choices = new string[]
        {
            "Add New Student",
            "Display List of Students With Marks & Grade",
            "Display Students obtaining a certain grade"
        };
        public void RunGradesApp()
        {
            // Distance Converter is output as heading
            ConsoleHelper.OutputHeading("Student Marks");

            var test = false;
            while (!test)
            {
                int Choice = ConsoleHelper.SelectChoice("test", Choices);
                 /// Return /confirm the choice made alongside the description.
                /// 
                if (Choice == 1)
                {
                AddNewStudent();
                }
                else if (Choice == 2)
                {
                DisplayListStudents();
                }
                else if (Choice == 3)
                {
                DisplayGradeProfile();
                }
            }
            
        }

        private void DisplayGradeProfile()
        {
            throw new NotImplementedException();
        }

        private void DisplayListStudents()
        {
            throw new NotImplementedException();
        }

        private void AddNewStudent()
        {
            throw new NotImplementedException();
        }

        public enum Grades
        {
            [Description("No Grade")]
            NULL,
            [Description("Fail")]
            F,  
            [Description("Third Class")]
            D, 
            [Description("Lower Second")]
            C, 
            [Description("Upper Second")]
            B, 
            [Description("First Class")]
            A
        }
    }
    
}
