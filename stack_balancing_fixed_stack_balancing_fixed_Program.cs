using System;

using System.Collections.Generic;



namespace StackClassDemo

{

    class Program

    {

        static void Main(string[] args)

        {
            string userString;
            Console.WriteLine("Input the string\n\n");
            userString = Console.ReadLine();
            int stringLength = userString.Length;
            Stack testStack = new Stack(stringLength);
            bool balanced = true;
            for (int i = 0; i < stringLength; i++)
            {
                if (IsOpenBracket(userString[i]))
                {
                    testStack.Push(Convert.ToString(userString[i]));
                }
                if (IsCloseBracket(userString[i]))
                {
                    if (testStack.Pop() != BracketConvert(userString[i]))
                    {
                        balanced = false;
                    }
                }
            }
            if (testStack.IsEmpty() == false)
            {
                balanced = false;
            }
            if (balanced)
            {
                Console.WriteLine("It is balanced");
            }
            else Console.WriteLine("Not balanced");
        } // end Main 

        public static bool IsOpenBracket(char chara)
        {
            if (chara == '(' || chara == '{' || chara == '[')
            {
                return true;
            }
            else return false;
        }

        public static bool IsCloseBracket(char chara)
        {
            if (chara == ')' || chara == '}' || chara == ']')
            {
                return true;
            }
            else return false;
        }

        public static string BracketConvert(char bracket1)
        {
            if (bracket1 == ')')
            {
                return "(";
            }
            if (bracket1 == '}')
            {
                return "{";
            }
            if (bracket1 == ']')
            {
                return "[";
            }
            else return "";
        }

    }

    class Stack

    {

        // attributes 

        private List<string> stackContents;

        private int maxSize;



        // constructor 

        public Stack(int size)

        {

            maxSize = size;

            stackContents = new List<string> { };

        }



        // display 
        public void Display()
        {
            for (int i = 0; i < stackContents.Count; i++)
            {
                Console.WriteLine(stackContents[i]);
            }
            Console.WriteLine("\n");
        }



        // push - make sure stack isn't full! 
        public void Push(string item)
        {
            if (!IsFull())
            {
                stackContents.Insert(0, item);
            }
        }


        // pop - make sure stack isn't empty! 
        public string Pop()
        {
            if (!IsEmpty())
            {
                string temp = stackContents[0];
                stackContents.RemoveAt(0);
                return temp;
            }
            else { return ""; }
        }
        // is it full
        public bool IsFull()
        {
            if (stackContents.Count == maxSize)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsEmpty()
        {
            if (stackContents.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Peek()
        {
            return stackContents[0];
        }
        public int Count()
        {
            int fart = stackContents.Count;
            return fart;
        }

    }



}

