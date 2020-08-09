using System;

namespace maxslicesum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(getmaxslicesum(new int[] { -10 }));
        }

        static int getmaxslicesum(int[] A)
        {
            int msf = 0, meh = Int32.MinValue;
            foreach (int i in A)
            {
                msf = msf + i;
                msf = Math.Max(msf, i);
                meh = Math.Max(msf, meh);
            }
            return meh;
        }
    }
}
