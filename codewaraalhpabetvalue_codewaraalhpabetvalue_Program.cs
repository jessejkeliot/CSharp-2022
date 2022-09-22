using System;

namespace codewaraalhpabetvalue
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "abc";
            string answer = "";
            char currentnum = ' ';
            int currentint = 0;
            int integer = 0;
            text = text.ToLower();
            for (int i = 0; i < text.Length; i++)
            {
                integer = (int)text[i] - 96;
                answer += " " + Convert.ToString(integer);
                Console.WriteLine(text[i]);
                Console.WriteLine(integer);
            }

            Console.WriteLine(answer);
        }
    }
}

