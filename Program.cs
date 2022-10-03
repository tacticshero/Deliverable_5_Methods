using System;
namespace Deliverable__5__Methods;

class Program
{
    // Method 1: Randomly populates an array with integers numbers between 10 and 50.
    // The array length is a parameter for the method. 
    static int[] random_array(int array_len)
    {
        Random random = new Random();
        int[] MyArray = new int[array_len];
        for (int i = 0; i < array_len; i++)
        {
            MyArray[i] = random.Next(10,50);
        }

        return MyArray;
    }
    //Method 2: Return the summation of all the elements of an array (the array is the parameter for this method). 
    static int sum(int[] Array)
    {
        int MySum = Array.Sum();

        return MySum;
    }

    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter an integer number between 5 and 15: ");
            int input = int.Parse(Console.ReadLine());

            if (input >= 5 & input <= 15)
            {
                int[] myArray = random_array(input);

                Console.Write("The elements in the random array are: ");

                foreach (int i in myArray)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine("\nThe sum is: " + sum(myArray));
            }
            else
            {
                Console.WriteLine("Enter an integer within the acceptable range");
            }

        }
        catch
        {
            Console.WriteLine("Enter an integer data type");

        }
    }
}