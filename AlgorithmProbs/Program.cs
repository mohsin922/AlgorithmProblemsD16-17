using System;
using System.Collections.Generic;
using System.IO;

namespace AlgorithmProbs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs!");

            Console.WriteLine("\nBinary Search the word from wordlist");
            string txtpath = File.ReadAllText(@"C:\Users\MOHSIN ZAHOOR PEER\Desktop\AlgorithmProbs\AlgorithmProbs\Alg.txt");
            List<string> words = new List<string>(txtpath.Split());
            words.Sort();
            BinarySearch.BinarySearchWord(words);
        }
    }
}