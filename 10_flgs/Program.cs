using System;
using System.Collections.Generic;
using System.Linq;

namespace flags
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getflags(new int[] { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 }));
        }

        static int getflags(int[] A)
        {
            int count = 0, K = 0;
            List<int> peaks = new List<int>();
            for (int i = 1; i < A.Length - 1;)
            {
                if (A[i] > A[i - 1] && A[i] > A[i + 1]) // peak
                {
                    peaks.Add(i);
                    i += 2;
                }
                else // not peak
                {
                    i++;
                }
            }

            // Console.WriteLine(String.Join(',', peaks));
            K = peaks.Count;
            // Console.WriteLine("Total peaks are " + K);
            // 1,3,5,10
            int pwf = 0;
            if (peaks.Count > 0) { pwf = peaks[0]; count = 1; }

            for (int i = 1; i < peaks.Count; i++)
            {
                if (peaks[i] - pwf >= K)
                {
                    count++;
                    pwf = peaks[i];
                }
            }
            return count;
        }
    }
}
