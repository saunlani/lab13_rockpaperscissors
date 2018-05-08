using System;

namespace lab13_rockpaperscissors
{
    /* Rock paper scissors
     * prompts user for a name and opponent selection
     * prompts user to select rock, paper or scissors
     * displays player & opponent's choice.
     * displays deciding outcome
     * input validation throughout program
     * keeps track of wins and losses, displays the scores at the end of session
     * 
     * todo: ROSHAMBO CLASS, allows player to play AS "player1" or "player2"
     */

    public class Program
    {
        
        public static void Main(string[] args)
        {
            //instantiate empty player class and player1 and player2
            Player p = new Player();
            Player player1 = new Player("Rocky", Roshambo.rock);
            Player player2 = new Player("Toenail", p.generateRoshambo());

            //welcomes user and prompts for a name
            Console.WriteLine("Welcome to Rock Paper Scissors!\n");
            Console.Write("Enter your name:\n");
            string usernamechoice = Console.ReadLine();


            // selecting opponent
            bool selectingOpponent = true;
            while (selectingOpponent)
            {
                Console.WriteLine($"\nWould you like to play against {player1.Name} or {player2.Name} ?");
                string oppNameChoice = Console.ReadLine().ToLower();

                if (oppNameChoice != player1.Name.ToLower() && oppNameChoice != player2.Name.ToLower())
                {
                    Console.WriteLine($"{oppNameChoice} does not exist.");
                    continue;
                }

                int userwins = 0;
                int userlosses = 0;
                int draws = 0;
                string opponentName = "empty";
                string opponentChoice;

                // selecting rock, paper or scissors
                bool selectingRPS = true;
                while (selectingRPS)
                {
                    Console.WriteLine("\nRock, paper, or scissors?");
                    string rpsPick = Console.ReadLine().ToLower();
                    Console.WriteLine("");

                    if (Validator.ValidateRPS(rpsPick) == false)
                    {
                        continue; 
                    }
                        

                    else if (oppNameChoice == player1.Name.ToLower())
                    {
                        opponentName = player1.Name;
                        opponentChoice = player1.Choice.ToString();
                        Roshambo rps_choice;
                        Enum.TryParse(rpsPick, out rps_choice);
                        Console.WriteLine($"{usernamechoice}: {rpsPick}");
                        Console.WriteLine($"{opponentName}: {opponentChoice}\n");


                    }
                    else if (oppNameChoice == player2.Name.ToLower())
                    {
                        opponentName = player2.Name;
                        opponentChoice = player2.generateRoshambo().ToString();
                        Roshambo rps_choice;
                        Enum.TryParse(rpsPick, out rps_choice);
                        Console.WriteLine($"{usernamechoice}: {rpsPick}");
                        Console.WriteLine($"{opponentName}: {opponentChoice}\n");
                    }
                    else
                    {
                        continue;
                    }
                    if (rpsPick == opponentChoice)
                    {
                        Console.WriteLine("Draw!");
                        draws++;
                    }
                    else if (rpsPick == "paper" && opponentChoice == "rock" ||
                             rpsPick == "rock" && opponentChoice == "scissors" ||
                             rpsPick == "scissors" && opponentChoice == "paper")
                    {
                        Console.WriteLine($"{usernamechoice} wins!");
                        userwins++;
                    }
                    else if (opponentChoice == "paper" && rpsPick== "rock" ||
                             opponentChoice == "rock" && rpsPick == "scissors" ||
                             opponentChoice == "scissors" && rpsPick == "paper")
                    {
                        Console.WriteLine($"{opponentName} wins!");
                        userlosses++;
                    }

                    bool askToplayAgain = true;
                    while (askToplayAgain)
                    {
                        Console.WriteLine("Play Again?");
                        string userPlayAgainAns = Console.ReadLine().ToLower();
                        if (Validator.ValidatePlayAgain(userPlayAgainAns) == false)
                        {
                            continue;
                        }
                        else if (userPlayAgainAns == "y")
                        {
                            askToplayAgain = false;
                        }
                        else if (userPlayAgainAns == "n")
                        {
                            Console.WriteLine($"{usernamechoice}'s wins: {userwins}");
                            Console.WriteLine($"{usernamechoice}'s losses: {userlosses}");
                            Console.WriteLine($"Draws: {draws}");
                            Console.WriteLine("Goodbye!");
                            askToplayAgain = false;
                            selectingRPS = false;
                            selectingOpponent = false;
                        }
                    }
                }
            }
        } 
    }
}