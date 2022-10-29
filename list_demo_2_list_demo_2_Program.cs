using System;

using System.Collections.Generic;



class Program
{

    public static void Main(string[] args)
    {

        List<int> list1 = new List<int> { 2, 5, 15, 36, 47, 56, 59, 78, 156, 244, 268 };

        List<int> list2 = new List<int> { 18, 39, 42, 43, 66, 69, 100 };

        List<int> mergedList = new List<int> { };



        // merge the lists 
        for (int i = 0; i < list1.Count; i++)
        {
            mergedList.Add(list1[i]);
        }
        for (int i = 0; i < list2.Count; i++)
        {
            mergedList.Add(list2[i]);
        }
        mergedList.Sort();




        // display the lists 

        Display(list1);

        Display(list2);

        Display(mergedList);



    }



    public static void Display(List<int> list)

    {

        Console.Write("{");

        for (int i = 0; i < list.Count; i++)

        {

            Console.Write("{0}", list[i]);

            if (i < list.Count - 1)

            {

                Console.Write(", ");

            }

        }
        Console.WriteLine("}");

    }

}

