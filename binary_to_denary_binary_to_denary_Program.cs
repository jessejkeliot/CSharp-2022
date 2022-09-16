using System;

namespace binary_to_denary
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                int answer = 0;
                int column = 8;
                do
                {
                    Console.WriteLine("Enter Bit Value");
                    int bit = Convert.ToInt32(Console.ReadLine());
                    answer += column * bit;
                    column = column / 2;
                }
                while (column >= 1);
                Console.WriteLine("Decimal value is: {0}", answer);
            }
        }
    }
}

