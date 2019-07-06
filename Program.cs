using System;

namespace TestProject1
{
    class Program
    { 
        
    static void OddSort(int[] arr, int n)
    {
        
        int l = 0, r = n - 1;

        // Count of odd numbers 
        int k = 0;

        while (l < r)
        {
            // work through array to identify odd # and even #
            while (arr[l] % 2 != 0)
            {
                l++;
                k++;
            }
            while (arr[r] % 2 == 0 && l < r)
                r--;

            //sort the numbers
            if (l < r)
            {
                // swap arr[l] arr[r] 
                int temp = arr[l];
                arr[l] = arr[r];
                arr[r] = temp;

            }

        }

            // put odd numbers in ascending order 
            Array.Sort(arr, 0, k);
    }

    public static void Main(String[] args)
    {
        int[] arr = { 5, 3, 2, 8, 1, 4 };

        OddSort(arr, arr.Length);

        Console.WriteLine(String.Join(" ", arr));
    }
}
    

    
}
