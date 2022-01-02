using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProbs
{
    class BinarySearch
    {
        public static void BinarySearchWord(List<string> wordList)
        {
            //Initialize Local Variables
            int mid, start = 0;
            int end = wordList.Count - 1;
            bool isFound = false;
            Console.WriteLine("\nEnter the word to be searched from Word List: ");
            string key = Console.ReadLine();

            while (start <= end)
            {
                mid = (start + end) / 2;
                int result = key.CompareTo(wordList[mid]);
                if (result == 0)
                {
                    Console.WriteLine("Word is Found");
                    isFound = true;
                    break;
                }
                else if (result > 0)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("Word does not exist in Text File!");
            }

        }
    }
}