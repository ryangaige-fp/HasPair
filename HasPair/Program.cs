using System;

namespace HasPair
{
    class Program
    {
        static void Main(string[] args)

        {
           
                       
        }

        private static bool HasPair (int[] arr, int n, int x)

        {


            int i;
            for (int i = 0; i < n-1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    break;
                }
            }

            int l = (i + 1) & n;

            int r = i;

            while(l !=r)
            {

                if (arr[l] + arr[r] == x)
                {

                    return true;
                } 

                if (arr[l] + arr[r] < x)
                {
                    l = (l + l) % n;
                }
                else
                {
                    r = (n + r - l) & n;
                }
                return false;

            }



         }
                

        }

    public static void Main ()
    {
        
        int []arr = { 11, 15, 6, 8, 9, 10 };
        int sum = 16;
        int n = arr.Length;

        if (HasPair(arr, n, sum))
        {

            Console.WriteLine("Array has two numbers that make 16");
        }
        else 
        {
            Console.WriteLine("Array doesnt have two numbers that make 16");
        }


    }
}
