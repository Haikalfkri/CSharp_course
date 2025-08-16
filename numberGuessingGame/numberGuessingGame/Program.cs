using System.Security.Cryptography;

namespace numberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number Guessing Game

            // initialize random
            // Random random = new Random();

            // generate random number between 1 - 100
            //int randomNumber = random.Next(1, 101);

            // initialize guess
            // int guess = 0;

            // while (guess != randomNumber)
            //{
            //    // guess number
            //    Console.WriteLine("Guess a number between 1 - 100");
            //    guess = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"Guess: {guess}");

            //    // check if guess is less or greater than random number
            //    if (guess > randomNumber)
            //    {
            //        Console.WriteLine($"{guess} is too high!");
            //    } 
            //    else if (guess < randomNumber)
            //    {
            //        Console.WriteLine($"{guess} is too low!");
            //    }
            //}

            //Console.WriteLine("Your guess is correct!");


            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int guesses;
            int randomNum;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                randomNum = random.Next(min, max + 1);

                while (guess != randomNum)
                {
                    Console.WriteLine($"Guess a number between {min} - {max}: ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > randomNum)
                    {
                        Console.WriteLine($"{guess} is too high!");
                    } else if (guess < randomNum)
                    {
                        Console.WriteLine($"{guess} is too low!");
                    }
                    guesses++;
                }

                Console.WriteLine("Your Right!!");
                Console.WriteLine($"You right in {guesses} guesses");

                Console.Write("Do you want to play again? (yes/no): ");
                response = Console.ReadLine().ToLower();

                if (response == "yes" || response == "y")
                {
                    playAgain = true;
                } else if (response == "no" || response == "n")
                {
                    playAgain = false;
                } else
                {
                    Console.WriteLine("Invalid response");
                }

            }
            Console.WriteLine("Thanks for playing!!");
        }
    }
}