using System;
using System.Collections.Generic;

namespace frogriverone
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1,3,1,4,2,3,5,4 };
            int X = 5;
            
            Console.WriteLine(CheckIfFrogCanJump(A, X));
            
        }

        static int CheckIfFrogCanJump(int[] A, int X) {
            if(A.Length == 0) return -1;

            Dictionary<int, int> lookup = new Dictionary<int, int> (); // Create a lookup to identify if all numbers are in place ie. 1-n

            for(int i = 1; i <= X; i++) lookup.Add(i, -1); // initialise as -1
            
            for (int i = 0; i < A.Length; i++){
                if(lookup[A[i]] == -1) lookup[A[i]] = i; // map the first occurance of the number we are interested
            }

            // if either the n is not found or any of the interested number is not found return -1
            if(!lookup.ContainsKey(X) || lookup.ContainsValue(-1)) return -1; 

            int max = 0;
            // loop through the dictionary and get the max value.
            foreach(KeyValuePair<int, int> kvp in lookup) {
                max = Math.Max(kvp.Value, max);
            }
            return max;
        }
    }
}
