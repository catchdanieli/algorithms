using System;

namespace permmissingelem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {2,3,1,5};
            long max = 0;
            long total = 0;
            long missing = 0;
            if(A.Length == 0) Console.WriteLine(1);
            else {
                foreach(long i in A) {
                    max = Math.Max(max, i);
                    total+=i;
                }    
                missing = (max*((max+1))/2) - total;
                if(missing == 0) Console.WriteLine((int)(max+1));
                else Console.WriteLine(missing);
            }
        }
    }
}
