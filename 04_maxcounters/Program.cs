using System;
using System.Linq;

namespace maxcounters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {3,4,4,6,1,4,4,1,1};
            int N = 5;
            sol2(N, A).ToList().ForEach(x => Console.WriteLine(x));
        }
        static int[] MaxCounter(int N, int[] A) {
            int[] result = new int[N];
            int maximum = 0;
            int resetLimit = 0;

            for (int K = 0; K < A.Length; K++)
            {
                if (A[K] < 1 || A[K] > N + 1)
                    throw new InvalidOperationException();

                if (A[K] >= 1 && A[K] <= N)
                {
                    if (result[A[K] - 1] < resetLimit) {
                        result[A[K] - 1] = resetLimit + 1;
                    } else {
                        result[A[K] - 1]++;
                    }

                    if (result[A[K] - 1] > maximum)
                    {
                        maximum = result[A[K] - 1];
                    }
                }
                else
                {
                    // inefficiency here
                    //for (int i = 0; i < result.Length; i++)
                    //    result[i] = maximum;
                    resetLimit = maximum;
                }
            }

            for (int i = 0; i < result.Length; i++)
                result[i] = Math.Max(resetLimit, result[i]);

            return result;
        }

        static int[] sol2(int N , int[] A)   {

            int[] result = new int[N];
            int max = 0, reset = 0;
            for(int i = 1; i <= A.Length; i++) {
                if(A[i-1] >= 0 && A[i-1] <= N) {
                    result[A[i-1]-1] = Math.Max(result[A[i-1]-1], reset) + 1;
                    max = Math.Max(result[A[i-1]-1], max);
                }
                else {
                    reset = max;
                }
            }
            for(int i = 0; i< result.Length; i++) 
                result[i] = Math.Max(result[i], reset);

            return result;
        }
    }
}
