using ConsoleAppProject.App03;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static ConsoleAppProject.App03.StudentMarks;

namespace ConsoleApp.Test
{
    [TestClass] 
    public class TestStudentGrades
    {
        private readonly StudentGrades
            studentGrades = new StudentGrades();

        public void Convert0ToGradeF()
        {
            //Arrange
            Grades expectedGrade = Grades.F;

            // Act
            Grades actualGrade = studentGrades.ConvertToGrade(0);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        public void Convert39ToGradeF()
        {
            //Arrange
            Grades expectedGrade = Grades.F;

            // Act
            Grades actualGrade = studentGrades.ConvertToGrade(39);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }
    }
}
