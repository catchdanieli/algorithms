using System;
using System.Collections;
using System.Collections.Generic;

namespace brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckBrackets("}}}}"));
        }

        static int CheckBrackets(string S)
        {
            HashSet<char> o = new HashSet<char>() { '{', '(', '[' };            
            Dictionary<char, char> pair = new Dictionary<char, char>();
            pair.Add('}', '{');
            pair.Add(')', '(');
            pair.Add(']', '[');
            Stack A = new Stack();
            foreach (char i in S)
            {
                if (o.Contains(i)) A.Push(i); // if its open bracket stack it in
                else if (pair.ContainsKey(i))
                { // if closed bracket check if the first stacked is its pair
                    try{
                        if(pair[i] == (char)A.Pop()) continue;
                        else return 0;
                    }
                    catch(Exception) { 
                        return 0;
                    }
                }                
            }
            if(A.Count == 0) return 1;
            else return 0;
        }
    }
}
