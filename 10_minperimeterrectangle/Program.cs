using System;

namespace minperimeterrectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getminperi(36));
        }

        static int getminperi(int N)
        {
            if (N == 0) return 0;
            long i = 1, min = 2 * (1 + N);
            for (; i * i < N; i++)
            {
                if (N % i == 0)
                    min = Math.Min(min, 2 * (i + (N / i)));
            }
            if (i * i == N) min = Math.Min(min, 2 * (i + N / i));

            return Convert.ToInt32(min);
        }
    }
}
