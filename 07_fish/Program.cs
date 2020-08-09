using System;
using System.Collections;
using System.Collections.Generic;

namespace fish
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] A = { 4, 3, 6, 1, 5 };
            int[] B = { 0, 1, 1, 0, 0 };
            Console.WriteLine(FindLiveFish(A, B));
        }

        static int FindLiveFish(int[] A, int[] B)
        {
            Stack<int> aliveFishes = new Stack<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (aliveFishes.Count == 0)
                {
                    aliveFishes.Push(i);
                }
                else
                {
                    while (aliveFishes.Count != 0
                             && B[i] - B[aliveFishes.Peek()] == -1
                             && A[aliveFishes.Peek()] < A[i])
                    { aliveFishes.Pop(); }

                    if (aliveFishes.Count != 0)
                    { if (B[i] - B[aliveFishes.Peek()] != -1) aliveFishes.Push(i); }

                    else { aliveFishes.Push(i); }
                }
            }
            return aliveFishes.Count;
        }
    }
}
