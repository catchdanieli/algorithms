using System;
using System.Collections.Generic;
using System.Linq;

namespace oddoccurances
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {9,3,9,3,9,6,7,9,7};
            int odd =0;
            foreach(int i in A) {
                odd ^= i;
            }
            Console.WriteLine(odd);
        }
    }
}
