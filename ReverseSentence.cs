using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_PracticeProblem
{
   public class ReverseSentence
    {
        public static void call()
        {
            Console.WriteLine("Enter your String:");
            string name = Console.ReadLine();
            string[] arr = name.Split(" ");
            for(int i=arr.Length-1; i>=0; i--)
            {
                Console.Write(arr[i]+ " ");
            }
        }
    }
}
