using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_PracticeProblem
{
    internal class SumofArray
    {
        public static void call()
        {
            int[] arr = new int[6];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter " + i + "element : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Sum of the element of the array is:");
            int sum = 0;    
            foreach (int i in arr)
            {
             sum  = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
