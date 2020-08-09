using System;

namespace binarygap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number - ");
            int inVal = Convert.ToInt32(Console.ReadLine());
            string inValStr = Convert.ToString(inVal,2);
            Console.WriteLine($"binary gap for {inValStr} is {GetBinaryGap(inValStr)}");
        }

        static int GetBinaryGap(string inValStr) {
            int counter =0 , maxcounter = 0;
            foreach(char c in inValStr) {
                if(c == '0') counter++;
                else { 
                    maxcounter = Math.Max(maxcounter,counter);
                    counter = 0;
                }
            }
            return maxcounter;
        }
    }
}
