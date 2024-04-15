using System;

namespace ConsoleApps
{
    public class StringFunction
    {
        public void Start()
        {
            do
            {
                StringLength();
                PredictMyDay();

                // After the fortune teller game ask if the user wants to play again.
                Console.WriteLine();
                Console.Write("Do you want to play again? (y/n): ");
            } while (Console.ReadLine().ToLower() == "y");
        }

        private void StringLength()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine(" Write a text with any numbers");
            Console.WriteLine(" or character and press enter!");
            Console.WriteLine("----------------------------");
            string userInput = Console.ReadLine();
            int length = userInput.Length;
            string upperCaseText = userInput.ToUpper();
            Console.WriteLine("----------------------------");
            Console.WriteLine(" Strength Length");
            Console.WriteLine($" Converted text: {upperCaseText}");
            Console.WriteLine($" Number of characters: {length}");
            Console.WriteLine("----------------------------");
        }

        private void PredictMyDay()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" The Fortune Teller");
            Console.WriteLine("Let me predict your day. Select");
            Console.WriteLine("a number between 1 and 7");
            Console.WriteLine("--------------------------------");

            int day;
            if (int.TryParse(Console.ReadLine(), out day))
            {
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Keep calm on Mondays! You can fall apart!");
                        break;
                    case 2:
                    case 3:
                        Console.WriteLine("Tuesdays and Wednesdays break your heart!");
                        break;
                    case 4:
                        Console.WriteLine("Thursday is your lucky day, don't wait for Friday!");
                        break;
                    case 5:
                        Console.WriteLine("Friday, you are in love!");
                        break;
                    case 6:
                        Console.WriteLine("Saturday, do nothing and do plenty of it!");
                        break;
                    case 7:
                        Console.WriteLine("And Sunday always comes too soon!");
                        break;
                    default:                       
                        break;
                }
            }
            else
            {
                Console.WriteLine("No day? is a good day but it dosent exist!");
            }
        }
    }
}