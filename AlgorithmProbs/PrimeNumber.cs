using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProbs
{
    class PrimeNumber
    {
        public void Prime()
        {
            int num, i, flag;
            Console.Write("Prime numbers within a range of 0-1000:\n");
            for (num = 0; num <= 1000; num++)
            {
                flag = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }

                if (flag == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");
        }
    }
}