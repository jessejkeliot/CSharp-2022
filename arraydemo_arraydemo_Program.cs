using System;

namespace arraydemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Demo");

            Console.WriteLine("----------");



            // option 1 - give a size, then assign 
            string[] fartTypes = new string[8];
            fartTypes[0] = "wet";
            fartTypes[1] = "sloppy";
            fartTypes[2] = "silent";
            fartTypes[3] = "loud";
            fartTypes[4] = "brown";
            // option 2 - assign in-line (size is implied) 
            string[] words = new string[] {"ardvark", "banana", "carousel", "deadline", "effort", "fantastic", "geology", "household", "irritant" ,"jalopy"};
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"{i} : {words[i]}");
            }
            for (int i = words.Length - 1; i >-1; i--) // backwards from top
            {
                Console.WriteLine($"{i} : {words[i]}");
            }



            int[] numbers = new int[] { 12, 37, 94, 42, 83, 21, 56, 79, 65, 7};
            int average = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                average += numbers[i];
            }
            average = average / numbers.Length;
            Console.WriteLine(average); //finds average of numbers
            int smallest = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }
            Console.WriteLine(smallest);
            int largest = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }
            Console.WriteLine(largest);


            string[] fish = new string[] { "herring", "mackerel", "cod", "sole", "tuna", "anchovy", "salmon", "trout" };
            Console.WriteLine("Looking for a fish?");
            string find = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < fish.Length; i++)
            {
                if (fish[i] == find)
                {
                    found = true;
                }
            }
            Console.WriteLine($"Found = {found}");
        }
    }
}

