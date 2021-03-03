using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleApp.Test
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            // Arrange

            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = UnitEnum.MILE;
            converter.ToUnit = UnitEnum.FEET;

            converter.FromDistance = 1.0;

            // Act

            converter.CalculateDistance();

            double expectedDistance = 5280;

            // Assert

            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }

        [TestMethod]
        public void TestFeetToMiles()
        {
            // Arrange

            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = UnitEnum.FEET;
            converter.ToUnit = UnitEnum.MILE;

            converter.FromDistance = 5280;

            // Act

            converter.CalculateDistance();

            double expectedDistance = 1.0;

            // Assert

            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }

        [TestMethod]
        public void TestMilesToMetres()
        {
            // Arrange

            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = UnitEnum.MILE;
            converter.ToUnit = UnitEnum.METER;

            converter.FromDistance = 1.0;

            // Act

            converter.CalculateDistance();

            double expectedDistance = 1609.34;

            // Assert

            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }

        [TestMethod]
        public void TestMetresToMiles()
        {
            // Arrange

            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = UnitEnum.METER;
            converter.ToUnit = UnitEnum.MILE;

            converter.FromDistance = 1609.34;

            // Act

            converter.CalculateDistance();

            double expectedDistance = 1.0;

            // Assert

            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }

        [TestMethod]
        public void TestMetresToFeet()
        {
            // Arrange

            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = UnitEnum.METER;
            converter.ToUnit = UnitEnum.FEET;

            converter.FromDistance = 1.0;

            // Act

            converter.CalculateDistance();

            double expectedDistance = 3.28;

            // Assert

            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }

        [TestMethod]
        public void TestFeetToMetres()
        {
            // Arrange

            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = UnitEnum.FEET;
            converter.ToUnit = UnitEnum.METER;

            converter.FromDistance = 3.28;

            // Act

            converter.CalculateDistance();

            double expectedDistance = 1.0;

            // Assert

            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }


    }

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
