using System;

namespace areacalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 32");
            string userinp = Console.ReadLine();
            int userinpint = Convert.ToInt32(userinp);
            int counter = 0;
            int current = 0;
            int[] array1 = new int[32];
            string currentstr = "";
            int stringcount = 0;
            double strnew = 0;
            int length = 0;
            while (counter <32)
            {
                //Console.WriteLine(current);
                stringcount = 1;
                strnew = 1;
                current += 1;
                currentstr = Convert.ToString(currentstr);
                for (int i = 0; i < currentstr.Length; i++)
                {
                    char currentchar = currentstr[i];
                    int now = currentchar - '0';
                    length = currentstr.Length;
                    Console.WriteLine(length);
                    strnew = strnew + Math.Pow(now, length);
                    //Console.WriteLine(strnew);
                }

                if (strnew == current)
                {
                    Console.WriteLine(current);
                    array1[counter] = current;
                    counter += 1;
                }
            }
            Console.WriteLine("done");
            System.Console.WriteLine(array1[userinpint]);
        }
    }
}

