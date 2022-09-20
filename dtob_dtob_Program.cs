using System;

namespace dtob
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in the decimal");
            string decimalstr = Console.ReadLine();
            int answer = 123;
            string binstr = "";
            int remainder = 0;
            int decimalint = Convert.ToInt32(decimalstr);
            answer = decimalint;
            while (answer!= 0)
            {
                remainder = answer % 2;
                answer = answer / 2;
                binstr = Convert.ToString(remainder) + binstr;
            }
            Console.WriteLine(binstr);
        }
    }
}

