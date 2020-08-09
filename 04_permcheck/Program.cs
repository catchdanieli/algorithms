using System;
using System.Collections.Generic;
using System.Linq;

namespace permcheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {};
            Console.WriteLine(CheckPerm(A));
        }

        static int CheckPerm(int[] A) {
            if(A.Length == 0) return 0;
            List<int> B = A.ToList();
            B.Sort();
            for(int i = 1; i <= B.Count; i++) {
                if(i != B[i-1]) return 0;
            }
            return 1;
        }
    }
}
