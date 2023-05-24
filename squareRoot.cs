using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_PracticeProblem
{
    public class squareRoot
    {
        public static void call()
        {
            Console.Write("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            double root = 1;
            int i = 0;
           
            while (number > 0)
            {
                i = i + 1;
                root = (number / root + root) / 2;
                if (i == number + 1)
                {
                    break;
                }
            }

           
            Console.WriteLine("Square root:{0}", root);

        }
    }
}
