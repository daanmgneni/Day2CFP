using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_PracticeProblem
{
    class LongestSubstringLength
    {
       public static void call()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            int length = FindLongestSubstringLength(input);
            Console.WriteLine("Length of the longest substring without repeating characters: " + length);
        }

        public  static int FindLongestSubstringLength(string input)
        {
            int maxLength = 0;
            int startIndex = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int endIndex = 0; endIndex < input.Length; endIndex++)
            {
                if (dic.ContainsKey(input[endIndex]))
                {
                    startIndex = Math.Max(startIndex, dic[input[endIndex]] + 1);
                }

                dic[input[endIndex]] = endIndex;
                maxLength = Math.Max(maxLength, endIndex - startIndex + 1);
            }

            return maxLength;
        }
    }

}
