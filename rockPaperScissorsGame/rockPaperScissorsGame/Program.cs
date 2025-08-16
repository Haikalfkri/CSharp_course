namespace myProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String response;

            while (playAgain)
            {
                player = "";
                computer = "";

                while (player != "rock" && player != "paper" && player != "scissors")
                {
                    Console.WriteLine("Enter rock, paper, or scissors:");
                    player = Console.ReadLine().ToLower();
                }

                int randomNum = random.Next(1, 4);
                switch (randomNum)
                {
                    case 1:
                        computer = "rock";
                        break;
                    case 2:
                        computer = "paper";
                        break;
                    case 3:
                        computer = "scissors";
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);


                switch (player)
                {
                    case "rock":
                        if (computer == "rock")
                        {
                            Console.WriteLine("It's a tie!");
                        }
                        else if (computer == "paper")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "paper":
                        if (computer == "rock")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "paper")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else
                        {
                            Console.WriteLine("You lose!");
                        }
                        break;
                    case "scissors":
                        if (computer == "rock")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "paper")
                        {
                            Console.WriteLine("You win!");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        break;
                }

                Console.WriteLine("Do you want to play again? (yes/no)");
                response = Console.ReadLine().ToLower();

                if (response == "yes")
                {
                    playAgain = true;
                }
                else if (response == "no")
                {
                    playAgain = false;
                } else
                {
                    Console.WriteLine("Invalid response, try again!");
                }
            }
            Console.WriteLine("Thanks for playing!!");
        }
    }
}