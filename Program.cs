/* Author: Enzo Tafarello Negrao
Date: 2/16/2023
Description: Create a C# Console application that uses two methods */

using System;

namespace Deliveable5_Methods
{
    class Program
    {

        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }
            return MyArray;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                sum = sum + item;
            }
            return sum;
        }


        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integer between 5 and 15");
                int input = int.Parse(Console.ReadLine());


                if (input > 15 || input < 5)
                {
                    Console.WriteLine("Invalid input. The number must be between 5 and 15.");
                    return;
                }



                int[] sampleArray = random_array(input);

                Console.WriteLine("The element in the random array are: ");
                foreach (int element in sampleArray)
                {
                    Console.Write(element + " ");
                }

                Console.WriteLine(" ");
                Console.WriteLine("The sum is: " + sum(sampleArray));
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter an integer number.");
                return;
            }
        }

    }
}
