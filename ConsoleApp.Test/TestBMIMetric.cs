using ConsoleAppProject.App02;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleApp.Test
{
    [TestClass]
    public class TestBMIMetric
    {
        [TestMethod]
        public void TestUnderweightLowestMetric()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Metres = 5;
            calculator.Kilograms = 5;

            // Act

            calculator.BMICalculateMetric();

            double expectedDistance = 0.2;

            // Assert
            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }

        [TestMethod]
        public void TestUnderweightHighestMetric()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Metres = (double)1.50;
            calculator.Kilograms = 41;

            // Act

            calculator.BMICalculateMetric();

            double expectedDistance = 18.22;

            // Assert

            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }

        [TestMethod]
        public void TestNormalLowestMetric()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Metres = 1.50;
            calculator.Kilograms = 42;

            // Act

            calculator.BMICalculateMetric();

            double expectedDistance = 18.67;

            // Assert

            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }

        [TestMethod]
        public void TestNormalHighestMetric()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Metres = 1.50;
            calculator.Kilograms = 56;

            // Act

            calculator.BMICalculateMetric();

            double expectedDistance = 24.89;

            // Assert

            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }

        [TestMethod]
        public void TestOverweightLowestMetric()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Metres = 1.50;
            calculator.Kilograms = 57;

            // Act

            calculator.BMICalculateMetric();

            double expectedDistance = 25.33;

            // Assert

            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }

        [TestMethod]
        public void TestOverweightHighestMetric()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Metres = 1.50;
            calculator.Kilograms = 67;

            // Act

            calculator.BMICalculateMetric();

            double expectedDistance = 29.78;

            // Assert

            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }

        [TestMethod]
        public void TestClass1ObeseLowestMetric()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Metres = 1.50;
            calculator.Kilograms = 68;

            // Act

            calculator.BMICalculateMetric();

            double expectedDistance = 30.22;

            // Assert

            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }

        [TestMethod]
        public void TestClass1ObeseHighestMetric()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Metres = 1.50;
            calculator.Kilograms = 78;

            // Act

            calculator.BMICalculateMetric();

            double expectedDistance = 34.67;

            // Assert

            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }

        [TestMethod]
        public void TestClass2ObeseLowestMetric()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Metres = 1.50;
            calculator.Kilograms = 79;

            // Act

            calculator.BMICalculateMetric();

            double expectedDistance = 35.11;

            // Assert

            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }

        [TestMethod]
        public void TestClass2ObeseHighestMetric()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Metres = 1.50;
            calculator.Kilograms = 89;

            // Act

            calculator.BMICalculateMetric();

            double expectedDistance = 39.56;

            // Assert

            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }

        [TestMethod]
        public void TestClass3ObeseLowestMetric()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Metres = 1.50;
            calculator.Kilograms = 90;


            // Act

            calculator.BMICalculateMetric();

            double expectedDistance = 40.00;

            // Assert

            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }

        [TestMethod]
        public void TestClass3ObeseHighestMetric()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Metres = 1.50;
            calculator.Kilograms = 900;


            // Act

            calculator.BMICalculateMetric();

            double expectedDistance = 400;

            // Assert

            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }
    }
}
