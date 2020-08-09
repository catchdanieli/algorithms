using System;

namespace staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(findpossiblesteps(4));
        }
        
        static int findpossiblesteps(int A) {
            if(A == 0 || A == 1) return 1;

            int[] N = new int[A+1];
            N[0] = 1;
            N[1] = 1;
            for(int i = 2; i <= A; i++) {
                N[i] = N[i-1] + N[i-2];
            }
            return N[A];
        }
    }
}
