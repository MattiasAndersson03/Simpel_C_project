using System.Runtime.CompilerServices;

using System;

namespace ConsoleApps
{
    internal class TempConverter
    {
        int choice = 0;

        public void Start()
        {
            do
            {
                DisplayMenu();

                // Read users choice
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 2)
                {
                    Console.WriteLine("Invalid input. Please enter 0, 1, or 2.");
                }

                // Perform task based on users choice
                switch (choice)
                {
                    case 1:
                        FahrenheitToCelsius();
                        break;
                    case 2:
                        CelsiusToFahrenheit();
                        break;
                    default:                        
                        break;
                }

            } while (choice != 0);
        }

        private void DisplayMenu()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine(" Temperature Conversion Menu");
            Console.WriteLine("----------------------------");
            Console.WriteLine(" 1. Fahrenheit to Celsius");
            Console.WriteLine(" 2. Celsius to Fahrenheit");
            Console.WriteLine(" 0. Exit");
            Console.WriteLine("----------------------------");
            Console.Write("Enter your choice: ");
            
        }

        // Calculates Fahrenheit to celsius
        private void FahrenheitToCelsius()
        {
            for (double fahrenheit = 0; fahrenheit <= 212; fahrenheit += 10)
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"{fahrenheit} Fahrenheit = {celsius:F2} Celsius");
            }
        }

        // Calculates celsius to fahrenheit
        private void CelsiusToFahrenheit()
        {
            for (int celsius = 0; celsius <= 100; celsius += 5)
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{celsius} Celsius = {fahrenheit:F2} Fahrenheit");
            }
        }
    }
}
