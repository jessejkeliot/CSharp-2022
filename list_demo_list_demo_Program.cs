using System;
using System.Collections.Generic;

namespace list_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> clothes = new List<string>();
            Console.WriteLine(IsEmpty(clothes));
            Console.WriteLine(clothes.Count);
            clothes.Add("socks");
            DisplayList(clothes);
            clothes.Add("shoes");
            DisplayList(clothes);
            clothes.Add("hat");
            DisplayList(clothes);
            clothes.Add("socks");
            DisplayList(clothes);
            Console.WriteLine(CountItems(clothes, "socks"));
            Console.WriteLine(clothes.IndexOf("shoes"));
            Console.WriteLine(clothes.Count);
            clothes.Insert(2, "gloves");
            DisplayList(clothes);
            clothes.Remove("socks");
            DisplayList(clothes);
            clothes.Remove("shirt");
            DisplayList(clothes);
            clothes.Add("socks");
            DisplayList(clothes);
            clothes.Add("shorts");
            DisplayList(clothes);
            Console.WriteLine(clothes.Count);
            Console.WriteLine(clothes.IndexOf("gloves"));
        }
        static bool IsEmpty(List<string> list1)
        {
            if (list1.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int CountItems(List<string> list2, string string1)
        {
            int counter1 = 0;
            for (int i = 0; i < list2.Count; i++)
            {
                if (list2[i] == string1)
                {
                    counter1++;
                }
            }
            return counter1;
        }
        static void DisplayList(List<string> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine(l[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

