using System;

namespace maxslice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getmaxsum(new int[] { 5, -7, 3, 5, -2, 4, -1 }));
        }

        static int getmaxsum(int[] A) {
            int msf = Int32.MinValue, meh = 0;
            foreach(int a in A) {
                meh = meh + a;
                meh = Math.Max(meh, a);
                msf = Math.Max(meh, msf);
            }
            return msf;
        }
    }
}
