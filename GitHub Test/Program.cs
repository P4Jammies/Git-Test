using System;

namespace GitHub_Test
{
    class GuessingGame
    {
        static void Main(string[] args)
        {
            var gen = new Generate();
            Console.WriteLine("Hey, I'm thinking of a number between 0 and 100.\nCare to Guess?");
            int answer = gen.num(0, 100);

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

            Console.WriteLine("You guessed the number! It took you " + tries + " tries.");
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
