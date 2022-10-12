using System;

namespace encryptionXOR
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter what you want encrypted");
            //string unencrypted = Console.ReadLine();
            //Console.WriteLine("Please enter the key");
            //string key = Console.ReadLine();
            string unencrypted = "ABC def";
            char key = 'm';
            char key2 = 'd';
            int[] encrypted1list = new int[unencrypted.Length];
            int[] encrypted2list = new int[unencrypted.Length];
            int XOR;
            //first round
            for (int i = 0; i < unencrypted.Length; i++)
            {
                XOR = Convert.ToInt32(unencrypted[i]) ^ Convert.ToInt32(key);
                Console.WriteLine($"{unencrypted[i]} {Convert.ToInt32(unencrypted[i])} {key} XOR {XOR} ASCII CHAR {Convert.ToChar(XOR)}");
                encrypted1list[i] = XOR;
            }
            //second round
            for (int i = 0; i <unencrypted.Length; i++)
            {
                XOR = encrypted1list[i] ^ Convert.ToInt32(key2);
                Console.WriteLine($"XOR 2 -- {XOR}");
                encrypted2list[i] = XOR;
            }
            //display the final encrypted integers
            for (int i = 0; i < unencrypted.Length; i++)
            {
                Console.WriteLine(encrypted2list[i]);
            }
            string encryptedstr = "";
            for (int i = 0; i < unencrypted.Length; i++)
            {
                Console.WriteLine(Convert.ToChar(encrypted2list[i]));
                encryptedstr += Convert.ToString(Convert.ToChar(encrypted2list[i]));
            }
            //write it to a text file
            string text = encryptedstr;
            var path = "data.txt";
            File.WriteAllText(path, text);
            //decrypt
            Console.WriteLine("Decrypting \n");
            int[] unencrypted1list = new int[unencrypted.Length];
            //first round
            for (int i = 0; i < encrypted2list.Length; i++)
            {
                XOR = encrypted2list[i] ^ Convert.ToInt32(key);
                unencrypted1list[i] = XOR;
            }
            for (int i = 0; i < encrypted2list.Length; i++)
            {
                XOR = unencrypted1list[i] ^ Convert.ToInt32(key2);
                Console.WriteLine(Convert.ToChar(XOR));
            }
        }
    }
}

