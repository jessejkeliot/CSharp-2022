using System;

using System.Collections.Generic;



namespace StackClassDemo

{

    class Program

    {

        static void Main(string[] args)

        {

            Stack testStack = new Stack(10);

            string userString;
            int stringLength;
            Console.WriteLine("Please type the balanced string containing only (, { or [\n");
            userString = Console.ReadLine();
            stringLength = userString.Length;
            for (int i = 0; i < stringLength/2; i++)
            {
                string converted = Convert.ToString(userString[i]);
                if (IsOpposite(converted) != "")
                {
                    testStack.Push(Convert.ToString(userString[i]));
                    Console.WriteLine("added {0} to stack", userString[i]);
                }
            }
            int counter = stringLength/2;
            bool balanced = true;
            while (balanced)
            {
                Console.WriteLine();
                if (Convert.ToString(userString[counter]) == IsOpposite(testStack.Pop()))
                {
                    if (counter != stringLength - 1)
                    {
                        counter++;
                    }
                    else { Console.WriteLine(balanced);}
                }
                else { balanced = false; }
            }
        } // end Main 

        public static string IsOpposite(string chara)
        {
            if (chara=="(")
            {
                return ")";
            }
            if (chara == "{")
            {
                return "}";
            }
            if (chara == "[")
            {
                return "]";
            }
            else { return ""; }
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

