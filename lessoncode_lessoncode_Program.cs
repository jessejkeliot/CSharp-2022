using System;



namespace _2022_A3_Subroutines

{

    class Program

    {

        static void Main(string[] args)

        {
            // Calls to subroutines that don't yet exist 

            Print("Hello World!");



            int[] numbers = new int[] { 4, 7, 12, 18, 21, 30 };

            DisplayArray(numbers);



            string response = Input("What is your name?");



            double mean = Average(numbers);
            Console.WriteLine(mean);
        }



        // declare a procedure called Print 

        // Print will take a string as a parameter and display it 

        static public void Print(string s)
        {
            Console.WriteLine(s);
        }





        // declare a procedure called DisplayArray 

        // DisplayArray will take an array of integers as a parameter and display it 

        static void DisplayArray(int[] array1)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(Convert.ToString(array1[i]));
            }
        }





        // declare a function called Input 

        // Input will take a string as a parameter and use it as a prompt 

        // Input will return a string containing whatever the user entered 

        static string Input(string prompt)
        {
            Console.WriteLine(prompt);
            string answer = Console.ReadLine();
            return answer;
        }





        // declare a function called Average 

        // Average will take an array of integers (of any size) as a parameter 

        // Average will return a double containing the mean of the values in the array 

        static double Average(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            sum = sum / numbers.Length;
            double answer1 = Convert.ToDouble(sum);
            return answer1;
        }



    }

}


