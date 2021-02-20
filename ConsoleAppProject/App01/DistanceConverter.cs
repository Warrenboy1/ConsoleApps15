using System;
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
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;
        public const string FEET = "feet";
        public const string METRES = "metres";
        public const string MILES = "miles";

        public double FromDistance { get; set; }
        public double ToDistance { get; set; }

        public string FromUnit { get; set; }
        public string ToUnit { get; set; }

        public DistanceConverter()
        {
            FromUnit = MILES;
            ToUnit = FEET;
        }

        /// <summary>
        /// This method will recieve the inputs fromUnit and toUnit,
        /// calculating the distance and output them
        /// </summary>
        public void convertDistance()
        { 
            ConsoleHelper.OutputHeading("Distance Converter");

            FromUnit = SelectUnit(" Please select the from distance unit ");
            ToUnit = SelectUnit(" Please select the to distance unit ");

            Console.WriteLine($"\n Converting {FromUnit} to {ToUnit}");
           
            FromDistance = ConsoleHelper.InputNumber($"Please enter the number of {FromUnit} ");

            CalculateDistance();

            OutputDistance();
        }

        public void CalculateDistance()
        {
            if(FromUnit == MILES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if(FromUnit == FEET && ToUnit == MILES)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
            else if(FromUnit == MILES && ToUnit == METRES)
            {
                ToDistance = FromDistance * METRES_IN_MILES;
            }
            else if(FromUnit == METRES && ToUnit == MILES)
            {
                ToDistance = FromDistance / METRES_IN_MILES;
            }
            else if(FromUnit == METRES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_METRES;
            }
            else if(FromUnit == FEET && ToUnit == METRES)
            {
                ToDistance = FromDistance / FEET_IN_METRES;
            }
            
        }

        private string SelectUnit(string prompt)
        {
            string [] choices = 
            {
                FEET,
                METRES,
                MILES
            };

            Console.WriteLine(prompt);
            int choiceNo = ConsoleHelper.SelectChoice(choices);

            string unit = choices[choiceNo - 1];
            return unit;
        }

       

        private void OutputDistance()
        {
            Console.WriteLine($"\n {FromDistance} {FromUnit}" +
                $" is {ToDistance} {ToUnit}! \n");
        }
    }
}
