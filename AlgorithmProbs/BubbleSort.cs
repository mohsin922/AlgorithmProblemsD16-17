using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProbs
{
    class BubbleSort
    {
        public static void BubbleSortArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public static void PrintArray(int[] arr)
        {
            Console.WriteLine("\nThe Sorted array Using Bubble Sort : ");
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("\n");
        }
    }
}