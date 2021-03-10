using ConsoleAppProject.App02;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleApp.Test
{
    [TestClass]
    public class TestBMIImperial
    {
        [TestMethod]
        public void TestUnderweightLowestImperial()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Stones = 0;
            calculator.Pounds = 0;

            calculator.Feet = 5;
            calculator.Inches = 11;

            // Act

            calculator.BMICalculateImperial();

            double expectedDistance = 0;

            // Assert
            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }

        [TestMethod]
        public void TestUnderweightHighestImperial()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Stones = 0;
            calculator.Pounds = 132;

            calculator.Feet = 5;
            calculator.Inches = 11;

            // Act

            calculator.BMICalculateImperial();

            double expectedDistance = 18.41;

            // Assert

            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }

        [TestMethod]
        public void TestNormalLowestImperial()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Stones = 0;
            calculator.Pounds = 133;

            calculator.Feet = 5;
            calculator.Inches = 11;

            // Act

            calculator.BMICalculateImperial();

            double expectedDistance = 18.55;

            // Assert

            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }

        [TestMethod]
        public void TestNormalHighestImperial()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Stones = 0;
            calculator.Pounds = 179;

            calculator.Feet = 5;
            calculator.Inches = 11;

            // Act

            calculator.BMICalculateImperial();

            double expectedDistance = 24.96;

            // Assert

            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }

        [TestMethod]
        public void TestOverweightLowestImperial()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Stones = 0;
            calculator.Pounds = 180;

            calculator.Feet = 5;
            calculator.Inches = 11;

            // Act

            calculator.BMICalculateImperial();

            double expectedDistance = 25.10;

            // Assert

            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }

        [TestMethod]
        public void TestOverweightHighestImperial()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Stones = 0;
            calculator.Pounds = 215;

            calculator.Feet = 5;
            calculator.Inches = 11;

            // Act

            calculator.BMICalculateImperial();

            double expectedDistance = 29.98;

            // Assert

            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }

        [TestMethod]
        public void TestClass1ObeseLowestImperial()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Stones = 0;
            calculator.Pounds = 216;

            calculator.Feet = 5;
            calculator.Inches = 11;

            // Act

            calculator.BMICalculateImperial();

            double expectedDistance = 30.12;

            // Assert

            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }

        [TestMethod]
        public void TestClass1ObeseHighestImperial()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Stones = 0;
            calculator.Pounds = 250;

            calculator.Feet = 5;
            calculator.Inches = 11;

            // Act

            calculator.BMICalculateImperial();

            double expectedDistance = 34.86;

            // Assert

            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }

        [TestMethod]
        public void TestClass2ObeseLowestImperial()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Stones = 0;
            calculator.Pounds = 251;

            calculator.Feet = 5;
            calculator.Inches = 11;

            // Act

            calculator.BMICalculateImperial();

            double expectedDistance = 35.00;

            // Assert

            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }

        [TestMethod]
        public void TestClass2ObeseHighestImperial()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Stones = 0;
            calculator.Pounds = 286;

            calculator.Feet = 5;
            calculator.Inches = 11;

            // Act

            calculator.BMICalculateImperial();

            double expectedDistance = 39.88;

            // Assert

            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }

        [TestMethod]
        public void TestClass3ObeseLowestImperial()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Stones = 0;
            calculator.Pounds = 287;

            calculator.Feet = 5;
            calculator.Inches = 11;

            // Act

            calculator.BMICalculateImperial();

            double expectedDistance = 40.02;

            // Assert

            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }

        [TestMethod]
        public void TestClass3ObeseHighestImperial()
        {
            // Arrange

            BMI calculator = new BMI();

            calculator.Stones = 0;
            calculator.Pounds = 1000;

            calculator.Feet = 5;
            calculator.Inches = 11;

            // Act

            calculator.BMICalculateImperial();

            double expectedDistance = 139.46;

            // Assert

            double Answer = Math.Round(calculator.BMIResult, 2);

            Assert.AreEqual(expectedDistance, Answer);
        }
    }
}
