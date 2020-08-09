using System;
using System.Collections;

namespace nesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("())"));
        }

        public static int solution(String S)
        {
            Stack a = new Stack();
            foreach (char c in S)
            {
                if (c == '(') a.Push('(');
                else if( c == ')') 
                try {
                    a.Pop();
                }
                catch(Exception) { return 0; }
            }
            return a.Count == 0 ? 1 : 0;
        }
    }
}
