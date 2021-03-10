using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(100);
            Console.WriteLine(number);
            int userGuess = 0;
            int numberOfGuesses = 5;
            bool guessed = false;
            Console.WriteLine("I guessed a number from 1 to 100. You can try to guess it.");
            Console.WriteLine("Write your assumption:");

            String input = Console.ReadLine().Trim();
            while (!guessed && numberOfGuesses > 0)
            {
                numberOfGuesses--;

                try
                {
                    if (input.Length > 3)
                    {
                        Console.WriteLine("The number is too long");
                    }
                    else
                    {
                        userGuess = Convert.ToInt32(input);

                        if (userGuess > number)
                        {
                            Console.WriteLine($"The number {userGuess} is larger than my guess number.");
                        }
                        else if (userGuess < number)
                        {
                            Console.WriteLine($"The number {userGuess} is smaller than my guess number.");
                        }
                        else
                        {
                            Console.WriteLine("Well done. You guessed it!");
                            guessed = true;
                            break;
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered invalid data type. Please enter numbers only!");

                }
                if (numberOfGuesses <= 0)
                {
                    Console.WriteLine("Sorry to say it. But you lost!");
                }
                if (numberOfGuesses > 1)
                {
                    Console.WriteLine($"You have {numberOfGuesses} number of guesses left. Try again, I belive in you!");
                    Console.WriteLine("Make a guess one more time:");
                    input = Console.ReadLine().Trim();
                }
                else if (numberOfGuesses == 1)
                {
                    Console.WriteLine("You have the last guess. Try again, I belive in you!");
                    Console.WriteLine("Make a guess one more time:");
                    input = Console.ReadLine().Trim();
                }
                

            }
        }
    }
}
