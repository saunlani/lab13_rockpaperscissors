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
     */

    public class Program
    {
        
        public static void Main(string[] args)
        {
			string usernamechoice = "";
			Console.WriteLine("Welcome to Rock Paper Scissors!\n");
			bool gettingUsername = true;
			while (gettingUsername)
			{
				Console.Write("Enter your name:\n");
				usernamechoice = Console.ReadLine();

				if (Validator.ValidUserName(usernamechoice) == false)
				{
					continue;
				}
				else
				{
					gettingUsername = false;
				}

			}
			//welcomes user and prompts for a name
           


			//instantiate empty player class, a user, r;ock player and a random player
			RandoPlayer p = new RandoPlayer("generator",Roshambo.rock);
			UserPlayer user  = new UserPlayer(usernamechoice,p.generateRoshambo());
			RockPlayer Rocky = new RockPlayer("Rocky", Roshambo.rock);
			RandoPlayer RandomPlayer = new RandoPlayer("Rando", p.generateRoshambo());
         
            // selecting opponent
            bool selectingOpponent = true;
            while (selectingOpponent)
            {
                Console.WriteLine($"\nWould you like to play against {Rocky.Name} or {RandomPlayer.Name} ?");
                string oppNameChoice = Console.ReadLine().ToLower();

                if (oppNameChoice != Rocky.Name.ToLower() && oppNameChoice != RandomPlayer.Name.ToLower())
                {
                    Console.WriteLine($"{oppNameChoice} does not exist.");
                    continue;
                }

                //declares counter variables for scores
                int userwins = 0;
                int userlosses = 0;
                int draws = 0;

                //declares selected opponent name and rock paper scissor choice
                string opponentName;
                string opponentChoice;
                
                // selecting rock, paper or scissors
                bool selectingRPS = true;
                while (selectingRPS)
                {
                    Console.WriteLine("\nRock, paper, or scissors?");
					string userresponse = Console.ReadLine().ToLower();
                    
                    // validates if a valid RPS choice
					if (Validator.ValidateRPS(userresponse) == false)
                    {
                        continue;
                    }

                                   
					else if (oppNameChoice == Rocky.Name.ToLower())
					{
						opponentName = Rocky.Name;
						opponentChoice = Rocky.generateRoshambo().ToString();

					}
					else if (oppNameChoice == RandomPlayer.Name.ToLower())
					{
						opponentName = RandomPlayer.Name;
						opponentChoice = RandomPlayer.generateRoshambo().ToString();

					}
					else
					{
						continue;
					}


                    // parses string user input to a roshambo value
                    Enum.TryParse(userresponse, out Roshambo convertedChoice);

                    // user's choice now lives in UserPlayer Choice
                    user.Choice = convertedChoice;
                    
                    Console.WriteLine("");
                    
					Console.WriteLine($"{usernamechoice}: {user.Choice.ToString()}");
                    Console.WriteLine($"{opponentName}: {opponentChoice}\n");

					if (user.Choice.ToString() == opponentChoice)
                    {
                        Console.WriteLine("Draw!");
                        draws++;
                    }

                    // if the user wins
					else if (user.Choice.ToString() == "paper" && opponentChoice == "rock" ||
					         user.Choice.ToString() == "rock" && opponentChoice == "scissors" ||
					         user.Choice.ToString() == "scissors" && opponentChoice == "paper")
                    {
                        Console.WriteLine($"{usernamechoice} wins!");
                        userwins++;
                    }

                    // if the opponent wins
					else if (opponentChoice == "paper" && user.Choice.ToString()== "rock" ||
					         opponentChoice == "rock" && user.Choice.ToString() == "scissors" ||
					         opponentChoice == "scissors" && user.Choice.ToString() == "paper")
                    {
                        Console.WriteLine($"{opponentName} wins!");
                        userlosses++;
                    }
                    
                    // checks to see if the player wants to play again
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

                            //displays scores after play decides to stop playing.
                            Console.WriteLine($"\n{usernamechoice}'s wins: {userwins}");
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