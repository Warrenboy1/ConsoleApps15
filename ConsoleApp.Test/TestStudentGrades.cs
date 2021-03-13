using ConsoleAppProject.App03;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp.Test
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly Student
            studentGrades = new Student();

        private readonly int[] StatsMarks = new int[]
        {
            10, 20, 30, 40, 50, 60, 70, 80, 90, 100
        };

        public TestStudentGrades()
        {
            testMarks = new int[]
{
                10, 20, 30, 40, 50, 60, 70, 80, 90, 100
};
        }

        private int[] testMarks;

        [TestMethod]
        public void Convert0ToGradeF()
        {
            // Arrange
            Grades expectedGrade = Grades.F;

            // Act
            Grades actualGrade = studentGrades.ConvertToGrade(0);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void Convert39ToGradeF()
        {
            // Arrange
            Grades expectedGrade = Grades.F;

            // Act
            Grades actualGrade = studentGrades.ConvertToGrade(39);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void Convert40ToGradeD()
        {
            // Arrange
            Grades expectedGrade = Grades.D;

            // Act 
            Grades actualGrade = studentGrades.ConvertToGrade(40);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void Convert49ToGradeD()
        {
            // Arrange
            Grades expectedGrade = Grades.D;

            // Act 
            Grades actualGrade = studentGrades.ConvertToGrade(49);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void Convert50ToGradeC()
        {
            // Arrange
            Grades expectedGrade = Grades.C;

            // Act
            Grades actualGrade = studentGrades.ConvertToGrade(50);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void Convert59ToGradeC()
        {
            // Arrange
            Grades expectedGrade = Grades.C;

            // Act 
            Grades actualGrade = studentGrades.ConvertToGrade(59);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void Convert60ToGradeB()
        {
            // Arrange
            Grades expectedGrade = Grades.B;

            // Act
            Grades actualGrade = studentGrades.ConvertToGrade(60);

            // Assert 
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void Convert69ToGradeB()
        {
            // Arrange
            Grades expectedGrade = Grades.B;

            // Act
            Grades actualGrade = studentGrades.ConvertToGrade(69);

            // Assert 
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void Convert70ToGradeA()
        {
            // Arrange
            Grades expectedGrade = Grades.A;

            // Act
            Grades actualGrade = studentGrades.ConvertToGrade(70);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void Convert100ToGradeA()
        {
            // Arrange
            Grades expectedGrade = Grades.A;

            // Act
            Grades actualGrade = studentGrades.ConvertToGrade(100);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        //[TestMethod]
        //public void TestCalculateMean()
        //{
        //    // Arrange
        //    studentGrades.Marks = testMarks;

        //    double expectedMean = 55.0;

        //    // Act

        //    studentGrades.CalculateStats();

        //    // Assert

        //    Assert.AreEqual(expectedMean, studentGrades.Mean);
        //}

        //[TestMethod]
        //public void TestCalculateMin()
        //{
        //    // Arrange
        //    studentGrades.Marks = testMarks;
        //    int expectedMin = 10;

        //    // Act
        //    studentGrades.CalculateStats();

        //    // Assert
        //    Assert.AreEqual(expectedMin, studentGrades.Minimum);
        //}

        //[TestMethod]
        //public void TestGradeProfile()
        //{
        //    // Arrange

        //    studentGrades.Marks = testMarks;


        //    // Act
        //    studentGrades.CalculateGradeProfile();

        //    bool expectedProfile;
        //    expectedProfile =  ((studentGrades.GradeProfile[0] == 3) &&
        //                        (studentGrades.GradeProfile[1] == 1) &&
        //                        (studentGrades.GradeProfile[2] == 1) &&
        //                        (studentGrades.GradeProfile[3] == 1) &&
        //                        (studentGrades.GradeProfile[4] == 4));

        //    // Assert
        //    Assert.IsTrue(expectedProfile);
        //}
    }
}
