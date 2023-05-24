using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_PracticeProblem
{
   public class ConvertDays
    {
            public static void call()
            {
                Console.Write("Enter the number of days: ");
                int days = int.Parse(Console.ReadLine());

                int years = days / 365;
                int months = days / 30;
                int weeks = days / 7;

                Console.WriteLine($"Years: {years}");
                Console.WriteLine($"Months: {months}");
                Console.WriteLine($"Weeks: {weeks}");
            }
        
   }

}

