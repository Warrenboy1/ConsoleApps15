using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This Appl prompts the user to input a distance 
    /// measured in one unit (fromUnit) and it will calculate and 
    /// output the equivalent distance in another unit (toUnit).
    /// </summary>
    /// <author>
    /// Warren's Version 0.3
    /// </author>
    public class DistanceConverter
    {
        public Dictionary<UnitsEnum, double> Distance = new Dictionary<UnitsEnum, double>();
        public string[] Measurement = new string[]
            {
                EnumHelper<UnitsEnum>.GetName(UnitsEnum.FEET),
                EnumHelper<UnitsEnum>.GetName(UnitsEnum.METER),
                EnumHelper<UnitsEnum>.GetName(UnitsEnum.MILE)
            };

        // measurements number to be calculated from & to distance
        public double FromDistance { get; set; }
        public double ToDistance { get; set; }
       
        // What measurements are selected and put into the strings
        public UnitsEnum FromUnit { get; set; }
        public UnitsEnum ToUnit { get; set; }

        public DistanceConverter()
        {
            Distance.Add(UnitsEnum.FEET, 0.000189394);
            Distance.Add(UnitsEnum.METER, 0.000621371);
            Distance.Add(UnitsEnum.MILE, 1);
        }

        /// <summary>
        /// The main structure to use Distance Converter application
        /// Using ConsoleHelper.cs to get information depending
        /// on the parameter set.
        /// </summary>
        public void ConvertDistance()
        {
            // Distance Converter is output as heading
            ConsoleHelper.OutputHeading("Distance Converter");

            // This looks for and gets the Unit
            GetUnit();

            // Repeater checks if the ToUnit and FromUnit are the same.
            Repeater();

            Console.WriteLine($"\n Converting {FromUnit} to {ToUnit}");

            // Looks for an input to put into FromDistance to
            // convert the 2 different measurements 
            FromDistance = (double)(UnitsEnum)ConsoleHelper.InputNumber($"Please enter the" +
                                                $" number of {FromUnit} ");
            // Calculates the distance from the input recieved
            CalculateDistance();

            // Outputs result
            OutputDistance();
        }

        /// <summary>
        /// Gets the units from inputs to see 
        /// what they are measured from and to
        /// </summary>
        public void GetUnit()
        {

            Console.WriteLine(" Please Enter 2 different Distance Units" +
                                " to measure from and to");

            FromUnit = Distance.ElementAt(ConsoleHelper.SelectChoice(" Please select the from distance unit \n", Measurement) - 1).Key;
            ToUnit = Distance.ElementAt(ConsoleHelper.SelectChoice(" Please select the to distance unit \n", Measurement) - 1).Key;
        }

        /// <summary>
        /// RepeatUnit uses a do while loop incase that 
        /// the FromUnit and ToUnit have the same information.
        /// </summary>
        private void Repeater()
        {
            do
            {
                GetUnit();
            } while (FromUnit == ToUnit);
        }

        /// <summary>
        /// CalculateDistance Calculates what to do with the information it has recieved.
        /// There is no other possible recalculations at this point unless more options
        /// for calculating distances have been updated.
        /// </summary>
        public double CalculateDistance()
        {
            return Math.Round((Distance[FromUnit] / Distance[ToUnit] * FromDistance), 2);
        }

        /// <summary>
        /// Rounds the number within {ToDistance} to 2 decimal places
        /// and outputs the number as {Result}.
        /// </summary>
        private void OutputDistance()
        {

            //Result = ToDistance.ToString("0.##");

            Console.WriteLine($"\n {FromDistance} {FromUnit}" +
                $" is {CalculateDistance()} {ToUnit}! \n");

        }
    }

    public enum UnitsEnum
    {
        [Display(Name = "Meter")]METER,
        [Display(Name = "Feet")]FEET,
        [Display(Name = "Mile")]MILE
    }
}
