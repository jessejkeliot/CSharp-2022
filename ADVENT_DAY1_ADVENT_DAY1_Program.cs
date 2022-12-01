using System;

namespace ADVENT_DAY1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = System.IO.File.ReadAllLines("input.txt");
            int currentsum = 0;
            int largestsum = 0;
            int secondlargest = 0;
            int thirdlargest = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == "")
                {
                    if (currentsum > largestsum)
                    {
                        largestsum = currentsum;
                    }
                    else if (currentsum > secondlargest)
                    {
                        secondlargest = currentsum;
                    }
                    else if (currentsum > thirdlargest)
                    {
                        thirdlargest = currentsum;
                    }
                    currentsum = 0;
                }
                else
                {
                    currentsum += Convert.ToInt32(text[i]);
                }
            }
            int allsum = largestsum + secondlargest + thirdlargest;
            Console.WriteLine(allsum);
        }
    }
}

