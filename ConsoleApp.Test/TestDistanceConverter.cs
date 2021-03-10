using ConsoleAppProject.App01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
}
