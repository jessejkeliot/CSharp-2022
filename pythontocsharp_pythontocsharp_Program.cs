using System;

namespace pythontocsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Password Strength Analyser");
            Console.WriteLine("**************************");

            int uc = 0; int lc = 0; int sp = 0; int num = 0; int score = 0;

            Console.WriteLine("Please enter your password");
            string password = Console.ReadLine();

            if (password.Length >= 8)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (Char.IsUpper(password[i]))
                    {
                        Console.WriteLine($"{Convert.ToString(password[i])}, char, {Convert.ToInt32(password[i])}, UPPERCASE");
                        uc++;
                    }
                    else if (Char.IsLower(password[i]))
                    {
                        Console.WriteLine($"{Convert.ToString(password[i])}, char, {Convert.ToInt32(password[i])}, lowercase");
                        lc++;
                    }
                    else if (char.IsDigit(password[i]))
                    {
                        Console.WriteLine($"{Convert.ToString(password[i])}, char, {Convert.ToInt32(password[i])}, Number");
                        num++;
                    }

                    else
                    {
                        Console.WriteLine($"{Convert.ToString(password[i])}, char, {Convert.ToInt32(password[i])}, special character");
                        sp++;
                    }

                }
                if (uc>0)
                {
                    score++;
                }
                if (lc>0)
                {
                    score++;
                }
                if (num>0)
                {
                    score++;
                }
                if (sp>0)
                {
                    score++;
                }
                if (score>=3)
                {
                    Console.WriteLine("Your password is accepted");
                }
                else
                {
                    Console.WriteLine("******PASSWORD DENIED - Use at least different types of character******");
                }
            }
            else
            {
                Console.WriteLine("Password not accepted - too short");
            }
        }
    }
}

