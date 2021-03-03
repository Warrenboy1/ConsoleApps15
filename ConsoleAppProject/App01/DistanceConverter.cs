using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This Appl prompts the user to input a distance 
    /// measured in one unit (fromUnit) and it will calculate and 
    /// output the equivalent distance in another unit (toUnit).
    /// </summary>
    /// <author>
    /// Warren's Version 0.4
    /// </author>
    public class DistanceConverter
    {
        public Dictionary<UnitEnum, double> Distance = new Dictionary<UnitEnum, double>();
        public string[] Measurement = new string[]
            {
                EnumHelper<UnitEnum>.GetName(UnitEnum.FEET),
                EnumHelper<UnitEnum>.GetName(UnitEnum.METER),
                EnumHelper<UnitEnum>.GetName(UnitEnum.MILE)
            };

        // measurements number to be calculated from & to distance
        public double FromDistance { get; set; }
        public double ToDistance { get; set; }
       
        // What measurements are selected and put into the strings
        public UnitEnum FromUnit { get; set; }
        public UnitEnum ToUnit { get; set; }


        public DistanceConverter()
        {
            Distance.Add(UnitEnum.FEET, 0.000189394);
            Distance.Add(UnitEnum.METER, 0.000621371);
            Distance.Add(UnitEnum.MILE, 1);
        }

        /// <summary>
        /// Run Distance Converter App
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
            FromDistance = (double)(UnitEnum)ConsoleHelper.InputNumber($"Please enter the" +
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
            while (FromUnit == ToUnit)
            {
                GetUnit();
            }
        }

        /// <summary>
        /// CalculateDistance Calculates what to do with the information it has recieved.
        /// There is no other possible recalculations at this point unless more options
        /// for calculating distances have been updated.
        /// </summary>
        public double CalculateDistance()
        {
            ToDistance = Math.Round((Distance[FromUnit] / Distance[ToUnit] * FromDistance), 2);
            return ToDistance;
        }

        /// <summary>
        /// Rounds the number within {ToDistance} to 2 decimal places
        /// and outputs the number as {Result}.
        /// </summary>
        private void OutputDistance()
        {

            Console.WriteLine($"\n {FromDistance} {FromUnit}" +
                $" is {ToDistance} {ToUnit}! \n");

        }
    }
}