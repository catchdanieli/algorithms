using System;
using System.Collections.Generic;

namespace countfactors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Total factors is " + getFactors(5040)); //60
            Console.WriteLine("Total factors is " + getFactors(24)); // 
            // Console.WriteLine("Total factors is " + getFactors(34879));
            // Console.WriteLine("Total factors is " + getFactors(40320));
        }

        static int getFactors(int N)
        {
            int counter = 0; // counter for 1;
            long i = 1, n = N;
            for (; i * i < n; i++)
            {
                if (n % i == 0)
                {
                    counter += 2;
                }
            }
            if (i * i == n) counter++;
            return counter;
        }
    }
}
