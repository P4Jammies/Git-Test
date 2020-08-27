using System;

namespace GitHub_Test
{
    class GuessingGame
    {
        static void Main(string[] args)
        {
            var gen = new Generate();
            Console.WriteLine("Hey, welcome to the Guessing Game!\nWhat number would you like to start at?");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What number would you like to stop at?");
            int stop = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nI'm thinking of a number between " + start + " and " + stop + ".\nCare to Guess?");
            int answer = gen.num(start, stop);

            int guess = Convert.ToInt32(Console.ReadLine());
            int tries = 1;

            while (guess != answer)
            {
                if (guess < answer)
                {
                    Console.WriteLine("That was too low");
                    tries++;
                }
                else if (guess > answer)
                {
                    Console.WriteLine("That was too high");
                    tries++;
                }

                Console.WriteLine("\nCare to try again?");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            string plural = tries == 1 ? " try" : " tries";
            Console.WriteLine("You guessed the number! It took you " + tries + plural + ".");
        }
    }

    class Generate
    {
        private readonly Random random = new Random();

        public int num(int min, int max) {
            return random.Next(min, max);
        }
    }
}
