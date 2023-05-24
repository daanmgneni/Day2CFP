namespace Day2_PracticeProblem
{
    public class Findgap
    {
        public static void call()
        {
            int[] arr = new int[6];
            int n = arr.Length;
            Console.WriteLine("Enter the element of array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write ("Enter the " + i + " element:");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            //short array
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }


            }
            Console.WriteLine("Array after sorting:");
            for (int i = 0; i < arr.Length; i++)
            {
                 Console.Write(arr[i] + " ");
                Console.WriteLine();
            }

            int smallestGap = 1000 ;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int gap =arr[i + 1] - arr[i];
                if (gap <smallestGap)
                    smallestGap = gap;
            }

            Console.WriteLine("smallest gap is:"+ smallestGap);
        }
    }
}
