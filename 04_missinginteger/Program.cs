using System;
using System.Collections.Generic;
using System.Linq;

namespace missinginteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {1,2};
            Console.WriteLine(getMissingInteger(A));
        }

        static int getMissingInteger(int[] A) {            
            Dictionary<int, int> lookup = new Dictionary<int, int> ();
            int i = 0;
            foreach (int j in A) {
                if(j >= 0 && !lookup.ContainsKey(j)) lookup.Add(j, 0);
            }
            
            if(lookup.Count == 0) return 1;
            else {                
                for(i = 1; i <= lookup.Count; i++) {
                    if(!lookup.ContainsKey(i)) return i;
                }
            }
            return i;
        }
    }
}
