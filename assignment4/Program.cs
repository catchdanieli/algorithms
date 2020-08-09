using System;
using System.Collections.Generic;
using System.Text;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> result = new List<string> ();
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++) {
                string temp = Console.ReadLine();
                string inStr = Console.ReadLine();

                string[] tempArray = temp.Split(' ');
                int strLength = 0, occr = 0;
                if(tempArray.Length > 1) {
                    strLength = Convert.ToInt32(tempArray[0]);
                    occr = Convert.ToInt32(tempArray[1]);
                }                
                result.Add(GetOccurences(inStr, strLength, occr));
            }
            
            result.ForEach(x => Console.WriteLine(x));
        }

        static string GetOccurences(string inStr, int strLength, int occr) {
            Dictionary<char, int> counter = new Dictionary<char, int> ();
            StringBuilder sb = new StringBuilder();
            foreach(char c in inStr) {
                if(!counter.ContainsKey(c)){
                    counter.Add(c, 1);
                    sb.Append(c);
                }
                else if(counter[c] < occr) {
                    counter[c]++;
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
