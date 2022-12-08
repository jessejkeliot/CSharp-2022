using System;
    class Program{
        static void Main(string[] args){
            string[] gift_list = { "partridge in a pear tree", "turtle doves", "French hens", "calling birds", "gold rings", "geese a-laying", "swans a-swimming", "maids a-milking", "ladies dancing", "lords a-leaping", "pipers piping", "drummers drumming" };
            string[] ordinals = { "first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eigth", "ninth", "tenth", "eleventh", "twelfth" };
            string[] numbers = { "a", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve" };
        for (int count = 1; count < 13; count++){
            Console.WriteLine($"\nOn the {ordinals[count - 1]} day of christmas my true love sent to me");
            for (int i = count; i > 0; i--){
                if (i == 1 && count > 1) { Console.Write("and "); }
                Console.WriteLine($"{numbers[i - 1]} {gift_list[i - 1]}");}}}}
    

