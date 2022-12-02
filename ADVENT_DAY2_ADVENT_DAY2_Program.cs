using System;

namespace ADVENT_DAY2
{
    class Program
    {
        static void Main(string[] args)
        {
            int overall_total = 0;
            string[] text = System.IO.File.ReadAllLines("input2.txt");
            for (int i = 0; i < text.Length; i++)
            {
                overall_total += CalculateScore(text[i]);
            }
            Console.WriteLine(overall_total);
        }
        static int CalculateScore(string line)
        {
            // 0 = rock, 1 = paper, 2 = scissors
            int total = 0;
            int opponentchoice = 0;
            int playerchoice = 0;
            Console.WriteLine($"{line[0]}, {line[2]}");
            if (line[0] == 'A')
            {
                opponentchoice = 0;
            }
            if (line[0] == 'B')
            {
                opponentchoice = 1;
            }
            if (line[0] == 'C')
            {
                opponentchoice = 2;
            }
            if (line[2] == 'X')
            {
                playerchoice = 0;
            }
            if (line[2] == 'Y')
            {
                playerchoice = 1;
            }
            if (line[2] == 'Z')
            {
                playerchoice = 2;
            }
            //who won
            int result = PlayerWonCheck(opponentchoice, playerchoice);
            Console.WriteLine($"{result}");
            total += result + playerchoice + 1;
            Console.WriteLine(total);
            return total;
        }
        static int PlayerWonCheck(int o, int p)
        {
            int outcome = 0;
            if (p>o || (p==0 && o==2))
            {
                outcome = 6;
            }
            else if (p == o)
            {
                outcome = 3;
            }
            else { outcome = 0; }
            Console.WriteLine(outcome);
            // outcome 0 = player lost, 6 = player won, 3 = a draw
            return outcome;
        }
    }
}

