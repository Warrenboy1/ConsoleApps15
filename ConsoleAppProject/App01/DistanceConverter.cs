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
            OutputHeading();

            FromUnit = SelectUnit(" Please select the from distance unit ");
            ToUnit = SelectUnit(" Please select the to distance unit ");

            Console.WriteLine($"\n Converting {FromUnit} to {ToUnit}");
           
            FromDistance = InputDistance($"Please enter the number of {FromUnit} ");

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
            string choice = DisplayChoices(prompt);
            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n you have chosen {unit}");
            return unit;
        }

        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice.Equals("2"))
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }
            else
            {
                Console.WriteLine("Something went wrong." +
                    " Make sure to choose a number listed.");
                return null;
            }
            
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("             Convert Distance          ");
            Console.WriteLine("         By Warren Frank-Danvers       ");
            Console.WriteLine("-------------------------------------\n");

        }


        /// <summary>
        /// Prompt the user to input the distance in miles
        /// Input the miles as a double number
        /// </summary>
        private double InputDistance(string input)
        {
            Console.Write(input);

            

            try 
            {
                return Convert.ToDouble(Console.ReadLine()); 
            } 
            catch (Exception) 
            { 
                Console.WriteLine("Something went wrong. Make sure you input a double number!");
                return 0; 
            }
        }

        private void OutputDistance()
        {
            Console.WriteLine($"\n {FromDistance} {FromUnit}" +
                $" is {ToDistance} {ToUnit}! \n");
        }
    }
}
