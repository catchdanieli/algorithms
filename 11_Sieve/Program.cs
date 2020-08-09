using System;
using System.Collections;

namespace sieve
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getPrimeCount(5));
        }

        static int getPrimeCount(int A)
        {
            BitArray sieve = new BitArray(A + 1, true);
            sieve[0] = sieve[1] = false;
            int i = 2;
            while (i * i < A)
            {
                if (sieve[i])
                {
                    int k = i * i;
                    while (k <= A)
                    {
                        sieve[k] = false;
                        k += i;
                    }
                }
                i += 1;
            }

            foreach (var item in sieve)
            {
                Console.WriteLine(item);
            }
            return 0;
        }

        static void getPrimeCount1(int n)
        {
            BitArray sieve = new BitArray(n+1, true);
            sieve[0] = sieve[1] = false;
            int i = 2;
            while(i * i > n)
        }
    }
}
