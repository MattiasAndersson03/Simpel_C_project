namespace ConsoleApps
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            SetupConsoleWindow();
            //Temprature Converter start
            TempConverter tempConverter = new TempConverter();
            tempConverter.Start();

            Continue();

            // Stringfunction start
            StringFunction stringFunction = new StringFunction();
            stringFunction.Start();

        }
        // Change console tittle and sets background color to white and text color to black
        private static void SetupConsoleWindow()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Assignment 2 Mattias Andersson";

        }
        // Calls method to continue to next program
        private static void Continue()
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("       String Functions");
        }
    }
}