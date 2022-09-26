using System;

namespace email_validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string TestEmail = "fart,a@gaming.com";
            bool IsValidEmail(string email)
            {
                bool isAt = false;
                bool valid = true;
                int counter = 0;
                int atindex = 0;
                while (isAt == false)
                {
                    //Console.WriteLine(email[counter]);
                    //Console.WriteLine(Char.IsLetterOrDigit(email[counter]));
                    if (email[counter] == '@')
                    {
                        isAt = true;
                        atindex = counter;
                    }
                    else if (Char.IsLetterOrDigit(email[counter]) == false)
                    {
                        valid = false;
                        isAt = true;
                    }
                    else if (email[counter] != '-' || email[counter] != '_')
                    {
                        valid = false;
                        isAt = true;
                    }
                    if (Char.IsLetterOrDigit(email[counter]) == true)
                    {
                        isAt = false;
                        valid = true;
                    }
                    if (counter != email.Length - 1)
                    {
                        counter++;
                    }
                    else
                    {
                        valid = false;
                        Console.WriteLine("No @ sign");
                        isAt = true;
                    }
                    //Console.WriteLine(valid);
                    //Console.WriteLine(isAt);
                    //Console.WriteLine(atindex);
                }
                //if valid still is true, all characters before the @ are valid
                bool isDot = false;
                int dotindex = 0;
                counter = atindex + 1;
                //Console.WriteLine("starting post @ checks");
                while (isDot == false)
                {
                    //Console.WriteLine(email[counter]);
                    if (email[counter] == '.')
                    {
                        dotindex = counter; //stores position of dot
                        isDot = true;
                        if (counter <= atindex + 3)
                        {
                            valid = false;
                        }
                    }
                    else if (Char.IsLetterOrDigit(email[counter]) == false)
                    {
                        valid = false; //not valid if the char isnt a dot or ltr/dig
                        isDot = true; //end while loop
                    }
                    else
                    {
                        counter++;
                    }
                }
                counter = dotindex+1;
                //Console.WriteLine(valid);
                //Console.WriteLine("starting post . checks");
                //Console.WriteLine(email.Length - dotindex + 1);
                if (email.Length - dotindex+1 <4)
                {
                    Console.WriteLine("suffix too short");
                    valid = false;
                }
                while (valid)
                {
                    if (Char.IsLetter(email[counter]) == false)
                    {
                        valid = false;
                    }
                    else if (counter != email.Length -1)
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                
                return valid;
            }
            if (IsValidEmail(TestEmail))
            {
                Console.WriteLine("Email Address is valid");
            }
            else
            {
                Console.WriteLine("Email Address is invalid :[");
            }
        }
    }
}

