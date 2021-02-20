using System;
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
        
        private const string IMPERIAL = "imperial";
        private const string METRIC = "metric";
        private string choice;

        public string Choice { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double BMIResult { get; set; }

        public void calculator()
        { 
            ConsoleHelper.OutputHeading("Body Mass Index Calculator");

            Choice = ChooseUnits(choice);

            TheUnit(Choice);

            Console.WriteLine($"\n Weight = {Weight}" + $"\n Height = {Height}" + $"\n BMI = {BMIResult}");

            BMICalculator();

            BAME();
        }

        private void BAME()
        {
            Console.WriteLine("\n If you are a Black, Asian or other  ");
            Console.WriteLine("         minority ethnic group,        ");
            Console.WriteLine("        You have a higher risk!        ");
        }

        private void BMICalculator()
        {
            if (BMIResult < 18.50)
            {
                Console.WriteLine("Your BMI is {0}. You are Underweight",BMIResult);
            }
            else if (BMIResult >= 18.5 && BMIResult <= 24.9) 
            {
                Console.WriteLine("Your BMI is {0}. You are Normal", BMIResult);
            }
            else if (BMIResult >= 25.0 && BMIResult <= 29.9)
            {
                Console.WriteLine("Your BMI is {0}. You are Overweight", BMIResult);
            }
            else if (BMIResult >= 30.0 && BMIResult <= 34.9)
            {
                Console.WriteLine("Your BMI is {0}. You are Obese Class I", BMIResult);
            }
            else if (BMIResult >= 35.0 && BMIResult <= 39.9)
            {
                Console.WriteLine("Your BMI is {0}. You are Obese Class II", BMIResult);
            }
            else if (BMIResult >= 40.0)
            {
                Console.WriteLine("Your BMI is {0}. You are Obese Class III", BMIResult);
            }
        }

        private void TheUnit(string choice)
        {
            if (choice.Equals(IMPERIAL))
            {
                Weight = Input(" \n Enter your weight to the nearest pounds \n Weight > ");

                Height = Input(" \n Enter your height to the nearest inches \n Height > ");

                BMIResult = ((Weight) / (Height * Height)) * 703;
            }
            else if (choice.Equals(METRIC))
            {
                Weight = Input(" \n Enter your weight to the nearest KG \n Weight > ");

                Height = Input(" \n Enter your height to the nearest metres \n Height > ");

                BMIResult = (Weight) / (Height * Height);
            }
            else
            {
                Console.WriteLine("Please Choose Either 1. Imperial or 2. Metric Next time, thank you.");
            }
            
        }

       

        private int Input(string input)
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
        

        private string ChooseUnits(string prompt)
        {
            string choice = DisplayChoices(" Please Enter your choice > ");
            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n you have chosen {unit}");
            return unit;
            
        }

        private string DisplayChoices(string prompt)
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

        private static string ExecuteChoice(string choice)
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
