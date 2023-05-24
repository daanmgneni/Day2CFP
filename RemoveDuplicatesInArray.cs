using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_PracticeProblem
{
    public class RemoveDuplicatesInArray
    {
  
        public static void call()
        {
            object[] array = { 1, 2, 3, "hello", 2, "world", 3, 4.5, 1 };

            /*object[] newArray= new object[10] ;
            int j = 0;
            foreach (var item in array)
            {
                
                if (!newArray.Contains(item))
                {
                   
                    newArray[j] = item; 
                    j++;
                   
                }
            }
            */

            List<object> newArray = new List<object>();

            foreach (var item in array)
            {
                if (!newArray.Contains(item))
                {
                    newArray.Add(item);
                }
            }

            object[] newArrayAsArray = newArray.ToArray();


            Console.WriteLine("Original Array:");
            foreach (var item in array)
            {
                Console.Write(item + " , ");
            }

            Console.WriteLine("\nArray after removing duplicates:");
            foreach (var item in newArrayAsArray)
            {
                Console.Write(item + " , ");
            }
        }
    }

}

