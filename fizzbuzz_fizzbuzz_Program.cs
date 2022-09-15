using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int target = rand.Next(1, 11);
            bool guessed = false;
            int guesses = 1;
            while (!guessed && guesses <4)
            {
                Console.WriteLine("Pick any number between 1 and 10!");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == target)
                {
                    guessed = true;
                    Console.WriteLine("You won in {0} guesses", guesses);
                }
                if (number>target)
                {
                    Console.WriteLine("Lower");
                }
                if (number < target)
                {
                    Console.WriteLine("Higher");
                }
                guesses++;
            }
            if (guessed == false)
            {
                Console.WriteLine("too many guesses you lose");
            }
            
        }
    }
}

