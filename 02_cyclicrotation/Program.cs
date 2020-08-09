using System;
using System.Linq;

namespace cyclicrotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {3, 8, 9, 7, 6};
            int[] B = new int[A.Length];
            // List<int> B = new List<int> ();
            int K = 15;
            

            int length_A = A.Length;
            if(K > length_A) K = K % length_A; // If K is more than length of the array, it ideally is the rotation of their difference
            Console.WriteLine("Effective rotation is - " + K);
            if(K == length_A || K == 0) {      
                B = A;   
            }
            else {
                for(int i=0; i<A.Length; i++) {
                    //rotated index needs to "wrap" around end of array
                    int rotatedIndex = (i + K) % length_A;
                    B[rotatedIndex] = A[i];
                }  
            }            
            B.ToList().ForEach(x=>Console.Write(x));            
        }
    }
}
