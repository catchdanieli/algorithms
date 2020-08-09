using System;

namespace leader
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Console.WriteLine(GetLeader(new int[] { 2, 1, 1, 3, 4 }));
            Console.WriteLine(GetEquiLeader(new int[] { 4,3,4,4,4,2 }));
        }

        static void GetLeader(int[] A)
        {
            int candidate = -1;
            int value = -1;
            int size = 0;
            foreach (int i in A)
            {
                if (size == 0)
                {
                    value = i;
                    size++;
                }
                else
                {
                    if (value != i) size--;
                    else size++;
                }
            }
            if (size > 0) candidate = value;
            int count = 0;
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (candidate == A[i])
                {
                    count++;
                    if (index == -1 && count > A.Length / 2) index = i;
                }
            }
            //return index;
            if(count > A.Length/2) {
                leader = candidate;
                leaderCount = count;
            }
            // return leader;
        }

        static int GetEquiLeader(int[] A)
        {
            int leader = -1;
            int leaderCount = 0;
            int candidate = -1;
            int value = -1;
            int size = 0;
            foreach (int i in A)
            {
                if (size == 0)
                {
                    value = i;
                    size++;
                }
                else
                {
                    if (value != i) size--;
                    else size++;
                }
            }
            if (size > 0) candidate = value;
            int count = 0;
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (candidate == A[i])
                {
                    count++;
                    if (index == -1 && count > A.Length / 2) index = i;
                }
            }
            if(count > A.Length/2) {
                leader = candidate;
                leaderCount = count;
            }

            int result = 0;
            int leaderCounter = 0;
            int arrayCounter = 0;

            if (leader == -1) return 0;

            for (int i = 0; i < A.Length; i++)
            {
                arrayCounter++;
                if(A[i] == leader) leaderCounter++; 
                if(leaderCounter > (arrayCounter) / 2f && 
                    (leaderCount - leaderCounter) > (A.Length - arrayCounter) / 2f
                    )
                    result++;
            }

            return result;
        }
    }
}
