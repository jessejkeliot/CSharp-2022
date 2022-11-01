using System;

using System.Collections.Generic;



namespace StackClassDemo

{

    class Program

    {

        static void Main(string[] args)

        {

            Stack testStack = new Stack(6);

            int response;

            string stackItem;



            do

            {

                do

                {

                    testStack.Display();

                    Console.WriteLine("4: Count");

                    Console.WriteLine("3: Peek");

                    Console.WriteLine("2: Pop");

                    Console.WriteLine("1: Push");

                    Console.WriteLine("0: Quit");

                    response = Convert.ToInt32(Console.ReadLine());

                } while (response < 0 || response > 2);



                if (response == 1)

                {

                    Console.WriteLine("Enter a string to push: ");

                    stackItem = Console.ReadLine();

                    testStack.Push(stackItem);

                }

                else if (response == 3)
                {
                    Console.WriteLine(testStack.Peek());
                }

                else if (response == 4)
                {
                    Console.WriteLine(testStack.Count());
                }
                else if (response == 2)

                {

                    stackItem = testStack.Pop();

                    Console.WriteLine("Popped {0} from stack.", stackItem);

                }

            }

            while (response != 0);

        } // end Main 





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
        public void Display(){
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
        public string Pop() {
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

