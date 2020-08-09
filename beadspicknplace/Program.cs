using System;
using System.Collections.Generic;
using System.Linq;

namespace beadspicknplace
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<string> result = new List<string> ();
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++) {
                string temp = Console.ReadLine();
                string[] tempArray = temp.Split(' ');
                int k = 0;
                string inStr = "";
                if(tempArray.Count() > 0){
                    k = Convert.ToInt32(tempArray[0]);
                }
                if(tempArray.Count() > 1) {
                    inStr = tempArray[1];
                }
                
                if(k > 0 && !String.IsNullOrEmpty(inStr))
                    result.Add(getSortedString(k, inStr));
                else 
                    result.Add("");
            }
            foreach(string str in result) {
                Console.WriteLine(str);
            }
        }
        static string getSortedString(int k, string input)
        {
            string result = "";
            char[] beads = input.ToCharArray().Where(x => x != '\0').ToArray();

            string beadsString = new String(beads);
            List<char> beadsSorted = beads.ToList();       
            beadsSorted.Sort();

            if(k == 1) {
                char smallestChar = beadsSorted[0];
                int smallestCharIndex = Array.IndexOf(beads, smallestChar); 
                result = beadsString.Substring(smallestCharIndex) + beadsString.Substring(0, smallestCharIndex);
            }
            else {
                result = new String(beadsSorted.ToArray());
            }
            return result;
        }
    }
}

// d h f g b
// h f g b d
// f g b d h
// g b d h f
// b d h f g

// if k = 1  - get the smallest char and push it to front and leave the rest of the list as is.

// d h f g b - k is 2
// d f g b h - find the biggest of the first k(2) and move it to the end
// d g b h f
// d b h f g
// b h f g d