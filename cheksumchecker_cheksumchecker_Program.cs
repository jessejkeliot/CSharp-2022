using System;

namespace cheksumchecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the barcode");
            string barcode = Console.ReadLine();
            //string barcode = "5705831020047";
            int sum = 0;
            for (int i = 0; i < barcode.Length-1; i++)
            {
                char currentchar = barcode[i];
                int current = currentchar - '0';
                if (i%2 == 0){
                    sum += current;
                }
                else
                {
                    sum += current * 3;
                }
            }
            int checksum = sum % 10;
            if (checksum != 0)
            {
                checksum = 10 - checksum;
            } //TOOK me crazy time to get the final check to work because diff data types and they
            //are so hard to convert
            if ((Convert.ToString(checksum)) == Convert.ToString(barcode[12]))
            {
                Console.WriteLine("Barcode works");
            }
            else
            {
                Console.WriteLine("Errors Found");
            }
        }
    }
}

