using System;

namespace AlgorithmProbs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Problems!");
            String str = "CAR";
            int n = str.Length;
            Permutations permutations = new Permutations();
            permutations.permutation(str, 0, n - 1);
            permutations.IPermutation(str);
        }
    }
}
