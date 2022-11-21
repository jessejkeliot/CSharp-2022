using System;
using System.Collections.Generic;
namespace DictionaryDemo
{
    class Program
    {
        // Because I am extraordinarily kind, here are the key/value pairs for your dictionary
        Dictionary<int, string> codes1 = new Dictionary<int, string>() {
         { 'A', ".-" },
         { 'B', "-..." },
         { 'C', "-.-."},
         { 'D', "-.."},
         { 'E', "."},
         { 'F', "..-."},
         { 'G', "--."},
         { 'H', "...."},
         { 'I', ".."},
         { 'J', ".---"},
         { 'K', "-.-"},
         { 'L', "._.."},
         { 'M', "--"},
         { 'N', "-."},
         { 'O', "---"},
         { 'P', ".--."},
         { 'Q', "--.-"},
         { 'R', ".-."},
         { 'S', "..."},
         { 'T', "-"},
         { 'U', "..-"},
         { 'V', "...-"},
         { 'W', ".--"},
         { 'X', "_.._"},
         { 'Y', "-.--"},
         { 'Z', "--.."}
            };
static void Main(string[] args)
        {
            string inputText;
            Console.WriteLine("Please enter a message:");
            inputText = Console.ReadLine();
            Console.WriteLine(Text2Morse(inputText));
        }
        // takes a text string and returns a Morse code string 
        // words should be separated 
        static string Text2Morse(string text)
        {
            Dictionary<int, string> codes1 = new Dictionary<int, string>() {
         { 'A', ".-" },
         { 'B', "-..." },
         { 'C', "-.-."},
         { 'D', "-.."},
         { 'E', "."},
         { 'F', "..-."},
         { 'G', "--."},
         { 'H', "...."},
         { 'I', ".."},
         { 'J', ".---"},
         { 'K', "-.-"},
         { 'L', "._.."},
         { 'M', "--"},
         { 'N', "-."},
         { 'O', "---"},
         { 'P', ".--."},
         { 'Q', "--.-"},
         { 'R', ".-."},
         { 'S', "..."},
         { 'T', "-"},
         { 'U', "..-"},
         { 'V', "...-"},
         { 'W', ".--"},
         { 'X', "_.._"},
         { 'Y', "-.--"},
         { 'Z', "--.."},
         {' ' , " "}
            };
            string morse = "";
            //text = text.Replace(" ", "");
            text = text.ToUpper();
            // codey magic in here
            for (int i = 0; i < text.Length; i++)
            {
                morse += codes1[text[i]];
            }
            return morse;
        }
    }
}

