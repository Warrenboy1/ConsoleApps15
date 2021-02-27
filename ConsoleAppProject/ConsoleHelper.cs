using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject
{
    public static class ConsoleHelper
    {
        /// <summary>
        /// using the string and depending on what app which uses OutputHeading
        /// will display the title alongside by my name.
        /// </summary>
        public static void OutputHeading(string title)
        {
            Console.WriteLine("\n -------------------------------------");
            Console.WriteLine($" {title}          ");
            Console.WriteLine("          By Warren Frank-Danvers       ");
            Console.WriteLine(" -------------------------------------\n");
        }

        /// <summary>
        /// This method displays a list of numbered choices to the user,
        /// and they can select and the choice number is returned.
        /// </summary>

        public static int SelectChoice(string message, string[] choices)
        {
            // Display all the choices

            DisplayChoices(choices);

            // Get the user's choice


            int choiceNo = (int)InputNumber($" { message}>",
                                            1, choices.Length);
            return choiceNo;
            
        }

        /// <summary>
        /// prompt the user to input a number
        /// </summary>
        public static double InputNumber(string prompt)
        {
            double number = 0;
            bool isValid = false;

            do
            {
                Console.Write(prompt);
                string value = Console.ReadLine();

                try
                {
                    number = Convert.ToDouble(value);
                    isValid = true;
                }
                catch (Exception)
                {
                    isValid = false;
                    Console.WriteLine(" INVALID NUMBER !");
                }
            } while (!isValid);

            return number;
        }

        /// <summary>
        /// 
        /// </summary>

        public static double InputNumber(string prompt, double min, double max)
        {
            bool isValid = false;
            double number = 0;

            do
            {
                number = InputNumber(prompt);

                if (number < min || number > max)
                {
                    isValid = false;
                    Console.WriteLine($"Number must be between {min} and {max}");
                }
                else isValid = true;

            } while (!isValid);

            return number;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void DisplayChoices(string[] choices)
        {
            int choiceNo = 0;

            foreach (string choice in choices)
            {
                choiceNo++;
                Console.WriteLine($"    {choiceNo}.     {choice}");
            }
        }
    }
}
