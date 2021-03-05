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
        public Dictionary<Grades, Char> Grade = new Dictionary<Grades, Char>();
        public string[] Grader = new string[]
        {
            EnumHelper<Grades>.GetName(Grades.F),
        }
        public void RunGradesApp()
        {
            // Distance Converter is output as heading
            ConsoleHelper.OutputHeading("Student Marks");

            ConsoleHelper.SelectChoice("test", Grade);
        }
    



        public enum Grades
        {
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
