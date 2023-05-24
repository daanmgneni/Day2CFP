namespace Day2_PracticeProblem
{
    public class PrimeNo1To100
    {


        public static void call()
        {
            Console.WriteLine("print prime number between 1 to 100");
            bool isPrime = true;
            for (var i = 2; i <= 100; i++)
            {

                for (var j = 2; j <= 100; j++)
                {
                    
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + ",");
                }
                isPrime = true;

            }
        }
    }
}