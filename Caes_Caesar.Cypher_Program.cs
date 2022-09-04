using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        int shift = 3;
        string s = "jesse is great";
        string lowerstring = s.ToLower();
        int shiftplussed = shift + 96;
        char sh = (char)shiftplussed;
        string encrypted = "" + sh;
        List<int> encryptednums = new List<int>();
        foreach (char c in lowerstring)
        {
            int val = (int)c + shift;
            //encryptednums.Add(val);
            encrypted = encrypted + (char)val;
        }
        foreach (int x in encryptednums)
        {
            //encrypted = encrypted + (char)x;
        }
        Console.WriteLine(encrypted);
        //decryption
        Console.WriteLine("Please Input the encrypted string.");
        string encryptedinput = Console.ReadLine(); ;
        string keyrem = encryptedinput.Substring(1);
        int unshift = (int)encryptedinput[0];
        string decryptedstring = "";
        List<char> shiftlist = new List<char>();
        foreach (char currentchar in keyrem)
        {
            Console.WriteLine(currentchar);
            int temp = (int)currentchar - unshift + 96;
            Console.WriteLine(temp);
            char tempchar = (char)temp;
            shiftlist.Add(tempchar);
        }
        foreach (char y in shiftlist)
        {
            decryptedstring = decryptedstring + y;
        }
        Console.WriteLine(decryptedstring);
    }
}