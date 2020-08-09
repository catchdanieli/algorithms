using System;

namespace frogjmp
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 10, Y = 85, D = 30;
            Console.WriteLine(Math.Ceiling((Y-X)/(double)D));
            Math.Ceiling(((Convert.ToDouble(Y-X))/Convert.ToDouble(D)));

            int x = (int)Math.Ceiling((Y-X)/(double)D);

        }
    }
}
