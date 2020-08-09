using System;

namespace maxprofit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 23171, 21011, 21123, 21366, 21013, 21367 };
            Console.WriteLine(getmaxprofit(A));
        }

        static int getmaxprofit(int[] A)
        {
            if(A.Length == 0) return 0;
            int[] B = new int[A.Length];
            B[0] = 0;
            for (int i = 1; i < A.Length; i++)
                B[i] = A[i] - A[i-1];

            int msf = 0, meh = 0;
            foreach (int i in B)
            {
                meh = meh + i;
                meh = Math.Max(meh, i);
                msf = Math.Max(meh, msf);
            }
            return msf;
        }
    }
}
