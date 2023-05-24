using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_PracticeProblem
{
    public class SecondLargest
    {
        public  static void call()
        {
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter " + size + " elements in the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter " + i + "element : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int secondLargest = FindSecondLargestElement(arr);
            Console.WriteLine("The Second largest element in the array is: " + secondLargest);
        }

        public static int FindSecondLargestElement(int[] array)
        {
            int largest = array[0];
            int secondLargest = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > largest)
                {
                    secondLargest = largest;
                    largest = array[i];
                }
                else if (array[i] > secondLargest && array[i] != largest)
                {
                    secondLargest = array[i];
                }
            }

            return secondLargest;
        }
    }

}

