using System;
namespace lab13_rockpaperscissors
{
    public class Validator
    {
		public static bool ValidUserName(string input)
		{
			if (string.IsNullOrWhiteSpace(input))
			{
				Console.WriteLine("Invalid input");
				return false;
			}
			else
			{
				return true;
			}

		}
        public static bool ValidateRPS(string input)
        {
            if (input != "rock" &&
                input != "scissors" &&
                input != "paper")
            {
                Console.WriteLine("Invalid input.");
                return false;

            }
            else
            {
                return true;
            }
        }

        public static bool ValidatePlayAgain(string input)
        {
            if (input != "y" &&
                input != "n")
            {
                Console.WriteLine("Invalid response.");
                return false;

            }
            else
            {
                return true;
            }
        }
    }
}