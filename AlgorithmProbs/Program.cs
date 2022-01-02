using System;

namespace AlgorithmProbs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 23, 52, 84, 63, 41, 95, 29 };
            Console.WriteLine("The Array Before Bubble Sort : ");
            int n = arr1.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr1[i] + " ");
            }
            BubbleSort.BubbleSortArray(arr1);
            BubbleSort.PrintArray(arr1);

        }
    }
}
