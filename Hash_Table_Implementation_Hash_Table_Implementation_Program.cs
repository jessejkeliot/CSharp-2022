using System;



// You should not need to change anything in the Program class! 

// (Until you reach the extension tasks…) 

// ------------------------------------------------------------ 

class Program

{

    static void Main(string[] args)

    {

        // set up a new HashTable (this calls the HashTable class constructor)         
        HashTable testHashTable = new HashTable(11);



        // variables for menu system         
        int response;

        int value;

        int index;



        // loop for menu         
        do

        {

            do

            {

                testHashTable.Display();

                Console.WriteLine("1: Insert item");

                Console.WriteLine("2: Get index of item");

                Console.WriteLine("0: Quit");

                response = Convert.ToInt32(Console.ReadLine());

            } while (response < 0 || response > 2);



            if (response == 1)

            {

                Console.WriteLine("Enter an integer value to insert: ");

                value = Convert.ToInt32(Console.ReadLine());

                testHashTable.Add(value);

            }

            else if (response == 2)

            {

                Console.WriteLine("Enter value to search for: ");

                value = Convert.ToInt32(Console.ReadLine());

                index = testHashTable.Search(value);

                Console.WriteLine("{0} found at index {1}", value, index);

            }

        }

        while (response != 0);





    }



}

// ------------------------------------------------------------------- 



// Skeleton class definition for a hash table - add attributes and methods to make it work! 
class HashTable

{

    // ATTRIBUTES: array of ints to store data; variables for count of data and max size
    int maxSize;
    int[] hashArray;
    int skipValue = 1;
    int count;


    // constructor 

    public HashTable(int size)

    {

        // set up a new array of required size, set data count to 0, set max size to specified size  
        maxSize = size;
        hashArray = new int[maxSize];

    }



    // METHODS 



    // display contents of hash table alongside positions, eg: 

    // 0 : 567 

    // 1 : 124 

    // 2 : 98 

    public void Display()

    {
        for (int i = 0; i < hashArray.Length; i++)
        {
            Console.WriteLine($"{i} : {hashArray[i]}");
        }
        // your code here 

    }





    // return true if table is full, false otherwise 

    private bool IsFull()

    {

        // your code here 
        if (count == maxSize)
        {
            return true;
        }
        else return false;

    }





    // add an item to the array in the position determined by the simple hashing algorithm 

    // remember to deal with collisions! 

    // display an error if table is full 

    public void Add(int item)

    {

        // your code here 

        //modulo the item by maxSize
        if (!IsFull())
        {
            int skip = 0;
            while (hashArray[((item % maxSize)+skip) % maxSize] >0)
            {
                skip++;
            }
            hashArray[((item % maxSize)+skip) % maxSize] = item;
        }

    }







    // return the index of a specified item 

    // use the hashing algorithm! 

    // remember that there may have been a collision when the item was inserted 

    public int Search(int item)

    {

        // your code here 
        int position = item % maxSize;
        if (hashArray[position] == 0)
        {
            Console.WriteLine("Not in the table");
            return -1;//not there
        }
        else if (hashArray[position] == item)
        {
            //Console.WriteLine($"Found it, it was at position {position}");
            return position;
        }
        else
        {
            bool found = false;
            int counter1 = 0;
            int returnitem = 0;
            while (found == false && ((counter1+position) % maxSize) != maxSize)
            {
                counter1++;
                if (item == hashArray[(counter1+position) % maxSize])
                {
                    found = true;
                }
                if (hashArray[(counter1 + position) % maxSize] == 0)
                {
                    found = false;
                }
                if (counter1 == maxSize)
                {
                    found = false;
                }
            }
            if (found)
            {
                //Console.WriteLine($"Found it, it was at position {(position+counter1) % maxSize}");
                returnitem = (position + counter1) % maxSize;
                return returnitem;
            }
            else
            {
                Console.WriteLine("Not in the table");
                return -1;
            }
        }

    }



}
