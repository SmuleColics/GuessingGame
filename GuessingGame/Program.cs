using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int min = 1, max = 100;
            int tries, guess, toGuess;
            bool playGame = true;
            string response = "";

            while (playGame)
            {
                tries = 0;
                guess = 0;
                toGuess = random.Next(min, max + 1);

                while (guess != toGuess)
                {
                    Console.Write("Enter Guess: ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess <= max && guess >= min)
                    {
                        if (guess > toGuess)
                        {
                            Console.WriteLine($"{guess} is too high.");
                        }
                        else if (guess < toGuess)
                        {
                            Console.WriteLine($"{guess} is too low.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Try Again.");
                        continue;
                    }
                    tries++;
                }
                Console.WriteLine($"To Guess: {toGuess}");
                Console.WriteLine($"Tries   : {tries}");
                Console.WriteLine("You win!");

                while (response != "Y" && response != "N")
                {
                    Console.WriteLine("Do You Want to Play Again (Y/N): ");
                    response = Console.ReadLine().ToUpper();

                    if (response == "Y")
                    {
                        playGame = true;
                    }
                    else if (response == "N")
                    {
                        playGame = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Choose Either Y or N.");
                        // conti
                    }
                }
            }
            Console.WriteLine("Thanks For Playing!");

            Console.ReadKey();
        }
    }
}

