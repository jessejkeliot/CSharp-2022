using System;

namespace Auth
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userIDs = {"sally_A", "mbp", "Fred", "Emanuel"};
            string[] passwords = { "roadKill@23", "@LoveH3@rt", "Peac3&War", "Easy@S123" };

            while (true)
            {
                Console.WriteLine(userIDs.Length);
                Console.WriteLine("Please enter your user ID:  ");
                string testUserID = Console.ReadLine();
                Console.WriteLine("Please enter your password:  ");
                string testPassword = Console.ReadLine();
                bool userIDCorrect = false;
                bool passwordCorrect = false;

                for (int i = 0; i < userIDs.Length; i++)
                {
                    if (testUserID == userIDs[i])
                    {
                        userIDCorrect = true;
                        if (testPassword == passwords[i])
                        {
                            passwordCorrect = true;
                        }
                    }
                }
                if (userIDCorrect && passwordCorrect)
                {
                    Console.WriteLine($"Welcome {testUserID}. Access Granted.");
                }
                else
                {
                    Console.WriteLine("********************************");
                    Console.WriteLine("********* Entry Denied *********");
                    Console.WriteLine("UserID / Password not recognised");
                    Console.WriteLine("********************************");
                }
            }
        }
    }
}

