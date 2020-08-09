using System;

namespace tapeequilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] A = {3,1,2,4,3};
            long minDiff = long.MaxValue;
            long lefttotal = 0, righttotal = 0;
            long total = 0, diff = 0;
            if(A.Length == 0) Console.WriteLine("0");
            foreach(long l in A) { total+=l; }
            righttotal = total;

            Console.WriteLine("Total is " + total);
            
            for(int i = 1; i< A.Length; i++) {
                lefttotal = getLeftSum(i, A, lefttotal, total);
                righttotal = getRightSum(i, A, righttotal, total);
                diff = Math.Abs(lefttotal - righttotal);
                minDiff = Math.Min(diff, minDiff);
                Console.WriteLine("Equilibrium for item " + i + " is " + diff + " and diff is " + minDiff);
            }
        }

        static long getLeftSum(int index, int[] A, long lefttotal, long total) {
            lefttotal += A[index-1];
            return lefttotal;
        }
        static long getRightSum(int index, int[] A, long righttotal, long total) {
            righttotal -= A[index-1];
            return righttotal;
        }
    }
}
