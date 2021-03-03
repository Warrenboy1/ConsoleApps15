using System;
using System.Text;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {
        
        public const string IMPERIAL = "imperial";
        public const string METRIC = "metric";
        public string choice;

        public const int InchesInFeet = 12;
        public const int PoundsInStones = 14;

        public string Choice { get; set; }
        public double BMIResult { get; set; }

        // Imperial Details
        public int Stones { get; set; }
        public int Pounds { get; set; }
        public int Feet { get; set; }
        public int Inches { get; set; }
        // Metric Details
        public double Kilograms { get; set; }
        public double Metres { get; set; }

        // Health Details
        public const double Underweight = 18.5;
        public const double Normal = 25.0;
        public const double Overweight = 30.0;
        public const double ObeseLevel1 = 35.0;
        public const double ObeseLevel2 = 39.9;
        public const double ObeseLevel3 = 40.0;

        /// <summary>
        /// Run BMI App
        /// </summary>
        public void calculator()
        { 
            ConsoleHelper.OutputHeading("Body Mass Index Calculator");

            Choice = ChooseUnits(choice);

            TheUnit(Choice);

            HealthMessage();

            Console.WriteLine(BameMessage());
            Console.WriteLine(HealthMessage());
            ;
        }
        /// <summary>
        /// Display BMI message
        /// </summary>
        /// <returns></returns>
        public string BameMessage()
        {
            StringBuilder message = new StringBuilder("\n");

            message.Append("\n If you are a Black, Asian or other");
            message.Append("\n minority ethnic group,");
            message.Append("\n You have a higher risk!        ");

            return message.ToString();
        }

        /// <summary>
        /// Display Health Message
        /// </summary>
        /// <returns></returns>
        public string HealthMessage()
        {
            StringBuilder message = new StringBuilder("\n");
            double Answer = Math.Round(BMIResult, 2);

            if (Answer < Underweight)
            {
                message.Append($" Your BMI is {Answer}. You are Underweight");
            }
            else if (Answer >= Underweight && Answer <= Normal) 
            {
                message.Append($" Your BMI is {Answer}. You are Normal");
            }
            else if (Answer >= Normal && Answer <= Overweight)
            {
                message.Append($" Your BMI is {Answer}. You are Overweight");
            }
            else if (Answer >= Overweight && Answer <= ObeseLevel1)
            {
                message.Append($" Your BMI is {Answer}. You are Obese Class I");
            }
            else if (Answer >= ObeseLevel1 && Answer <= ObeseLevel2)
            {
                message.Append($" Your BMI is {Answer}. You are Obese Class II");
            }
            else if (Answer >= ObeseLevel3)
            {
                message.Append($" Your BMI is {Answer}. You are Obese Class III");
            }

            return message.ToString();
        }

        /// <summary>
        /// Choose between Imperial or Metric
        /// </summary>
        /// <param name="choice"></param>
        public void TheUnit(string choice)
        {
            if (choice.Equals(IMPERIAL))
            {
                ImperialInput();
                BMICalculateImperial();
            }
            else if (choice.Equals(METRIC))
            {
                MetricInput();
                BMICalculateMetric();
            }
            else
            {
                Console.WriteLine("Please Choose Either 1. Imperial or 2. Metric Next time, thank you.");
            }
            
        }

        /// <summary>
        /// Metric Input using weight in KG and height in Metres
        /// </summary>
        public void MetricInput()
        {
            Console.WriteLine(" \n Enter your weight to the nearest kilogram \n Weight > ");
            Kilograms = (int)ConsoleHelper.InputNumber(" Enter your weight in Kilograms > ");

            Console.WriteLine(" \n Enter your height to the nearest Metres \n Height > ");
            Metres = (int)ConsoleHelper.InputNumber(" Enter your height in Metres > ");

        }

        /// <summary>
        /// Imperial Input using weight in Stones & Pounds, height in Feet & Inches
        /// </summary>
        public void ImperialInput()
        {
                Console.WriteLine(" \n Enter your weight to the nearest stones & pounds \n Weight > ");
            Stones = (int)ConsoleHelper.InputNumber(" Enter your weight in Stones > ");
            Pounds = (int)ConsoleHelper.InputNumber(" Enter your weight in Pounds > ");

                Console.WriteLine(" \n Enter your height to the nearest Feet & Inches \n Height > ");
            Feet = (int)ConsoleHelper.InputNumber(" Enter your height in Feet > ");
            Inches = (int)ConsoleHelper.InputNumber(" Enter your height in Inches > ");
        }

        /// <summary>
        /// Calculate Metric 
        /// </summary>
        public void BMICalculateMetric()
        {
            BMIResult = ((double)Kilograms) / (Metres * Metres);
        }

        /// <summary>
        /// Calculate Imperial
        /// </summary>
        public void BMICalculateImperial()
        {
            Inches += Feet * InchesInFeet;
            Pounds += Stones * PoundsInStones;

            BMIResult = (double)Pounds
                * 703
                / (Inches * Inches);
        }

        /// <summary>
        /// Input changes to double
        /// </summary>
        public int Input(string input)
        {
            Console.Write(input);
            try
            {
                return (int)Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                 Console.WriteLine("Something went wrong. Make sure you input a number!");
                    return Input(input);
            }
        }

        /// <summary>
        /// Use Display choices to choose units 
        /// </summary>
        public string ChooseUnits(string prompt)
        {
            string choice = DisplayChoices(" Please Enter your choice > ");
            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n you have chosen {unit}");
            return unit;
        }

        /// <summary>
        /// Displays choices Imperial and Metric
        /// </summary>
        public string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($"\n Choose between");
            Console.WriteLine($"\n 1. {IMPERIAL} (weight in stones and pounds, height in feet and inches) ");
            Console.WriteLine($" 2. {METRIC} (weight in kg, and height in metres)");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// If choice equals to a certain number then return the string chosen
        /// </summary>
        public static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return IMPERIAL;
            }
            else if (choice.Equals("2"))
            {
                return METRIC;
            }
            else
            {
                Console.WriteLine("Something went wrong." +
                    " Make sure to choose a UNIT listed.");
                return null;
            }
        }
    }
}
