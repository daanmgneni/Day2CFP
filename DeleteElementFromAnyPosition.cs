using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_PracticeProblem
{
    internal class DeleteElementFromAnyPosition
    { 
       public static void call()
        {
            int[] arr =  new int[6];
            Console.WriteLine(" Enter the elements in the array :");
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Enter element - " + i + " : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Before deleting the element: ");
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }


            Console.WriteLine("Enter the position where to delete: ");
            int position = Convert.ToInt32(Console.ReadLine());

            if (position < 1 || position > arr.Length)
            {
                Console.WriteLine("Invalid position!");
            }
            else
            {
                int[] newArray = new int[arr.Length - 1];

                int j = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i != position - 1)
                    {
                        newArray[j] = arr[i];
                        j++;
                    }
                }
                Console.WriteLine("After deleting the element: ");
                foreach (int element in newArray)
                {
                    Console.Write(element + " ");
                }

            }
        }
       
    }

}
