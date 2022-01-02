﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProbs
{
    class MergeSort
    {
        public void Merging()
        {
            int[] numbers = { 58, 73, 53, 63, 99, 42, 20 };
            int len = numbers.Length;
            Console.WriteLine("Before Merge Sort:");
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("After Merge Sort");
            Sort(numbers, 0, len - 1);
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.Read();
        }
        static public void MergeMethod(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;
            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);
            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }
            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];
            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];
            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
        static public void Sort(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                Sort(numbers, left, mid);
                Sort(numbers, (mid + 1), right);
                MergeMethod(numbers, left, (mid + 1), right);
            }
        }
    }
}