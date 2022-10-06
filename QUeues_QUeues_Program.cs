using System;



namespace QUeues

{

    class Program

    {

        static void Main(string[] args)

        {

            // declare an empty queue of size 10 

            Queue testQueue = new Queue(10);



            // declare variables for user responses 

            int response;

            int value;



            // main loop 



            do

            {

                // show menu and (crudely) validate response 

                do

                {

                    testQueue.Display();

                    Console.WriteLine("1: Add item");

                    Console.WriteLine("2: Remove item");

                    Console.WriteLine("0: Quit");

                    response = Convert.ToInt32(Console.ReadLine());

                } while (response < 0 || response > 2);



                // call appropriate queue methods based on response 

                if (response == 1)

                {

                    Console.WriteLine("Enter an integer value to add: ");

                    value = Convert.ToInt32(Console.ReadLine());

                    testQueue.Enqueue(value);

                }

                else if (response == 2)

                {

                    value = testQueue.Dequeue();

                    Console.WriteLine("Removed {0} from queue.", value);

                }

            }

            // finish if 0 is chosen 

            while (response != 0);

        } // end Main 





    } // end Program class 





    // define a new Queue class 

    public class Queue

    {

        // PROPERTIES 

        // maxSize 
        int maxSize;
        // numItems 
        int numItems;
        // front pointer 
        int front;
        // rear pointer 
        int rear;
        // integer array queueContents 
        int[] queueContents;


        // CONSTRUCTOR(one argument) 
        
        // this is the code that is called when a new Queue object is declared 

        public Queue(int size)

        {
            maxSize = size;
            numItems = 0;
            front = 0;
            rear = -1;
            queueContents = new int[maxSize];
        }



        // method to add to queue 

        public void Enqueue(int item)

        {
            if (IsFull()){
                Console.WriteLine("Queue Full");
            }
            else {
                rear = (rear + 1) % maxSize;
                queueContents[rear] = item;
                numItems++;
            }
        }



        // method to remove from queue 

        public int Dequeue()

        {
            if (IsEmpty()){
                Console.WriteLine("Queue Empty");
                return -1;
            }
            else
            {
                int item = queueContents[front];
                front = (front + 1) % maxSize;
                numItems--;
                return item;
            }

        }



        // method to check if queue is full 

        private bool IsFull()

        {
            if (numItems == maxSize)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        // method to check if queue is empty 

        private bool IsEmpty()

        {
            if (numItems == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        // method to display the contents of the array and pointers 

        public void Display()

        {
            for (int i = 0; i < maxSize; i++)
            {
                if (i == rear)
                {
                        Console.WriteLine($"{i}: {queueContents[i]} <-rear");
                }
                else if (i == front)
                {
                    Console.WriteLine($"{i}: {queueContents[i]} <-front");
                }
                else{ Console.WriteLine($"{i}: {queueContents[i]}"); }
            }


        }

    }

}

