using System;

namespace countdiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(countdiv1(11, 345, 17));
            Console.WriteLine(countdiv1(6, 11, 2));
            Console.WriteLine(countdiv(11, 345, 17));
            Console.WriteLine(countdiv(6, 11, 2));
            Console.WriteLine(countdiv(10, 11, 10));
        }

        static int countdiv(int A, int B, int K) {
            if( A == B || (A < K && B < K)) return 0;

            if(!(A % K == 0 || B % K == 0)) 
                A = (int)Math.Ceiling((decimal)A / K * K);
            
            return ((B-A) / K) + 1;
        }

       

    }
}
