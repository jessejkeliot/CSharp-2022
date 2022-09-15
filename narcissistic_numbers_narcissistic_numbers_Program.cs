using System;

namespace narcissistic_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int current = 1;
            int total = 0;
            int[] listofnumbs = new int[32];
            while (counter<32)
            {
                total = 0;
                foreach (char i in Convert.ToString(current))
                {
                    string digit = Convert.ToString(i);
                    int newi = Convert.ToInt32(digit);
                    string currentstr = Convert.ToString(current);
                    int length = currentstr.Length;
                    total += Convert.ToInt32(Math.Pow(Convert.ToDouble(newi), Convert.ToDouble(length)));
                }
                if (current == total)
                {
                    listofnumbs[counter] = total;
                    Console.WriteLine(total);
                    counter++;
                }
                current++;
            }
        }
    }
}

