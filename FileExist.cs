using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day2_PracticeProblem
{
   public class FileExist
    {
      
       public  static void call()
        {
            string filePath = @"C:\Users\ASHISH PANDEY\source\repos\CFP\Day2_PracticeProblem\sample3.txt";

            if (File.Exists(filePath))
            {
                Console.WriteLine("The file path exists.");
            }
            else
            {
            
                File.Create(filePath);

                Console.WriteLine("The file path has been created.");
            }
        }
    }

}
