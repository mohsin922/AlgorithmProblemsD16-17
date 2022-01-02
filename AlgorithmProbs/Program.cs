using System;

namespace AlgorithmProbs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Algorithm Problems!");
            InsertionSort insertionSort = new InsertionSort();
            int[] arr = { 37, 72, 24, 93, 41, 55, 89 };
            Console.WriteLine("\nArray before Insertion Sort: ");
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            insertionSort.Sort(arr);
            insertionSort.PrintArray(arr);
        }
    }
}