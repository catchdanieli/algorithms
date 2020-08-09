using System;
using System.Collections.Generic;
using System.Linq;

namespace assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            // int t = Convert.ToInt32(Console.ReadLine());
            // for (int i = 0; i < t; i++)
            // {
            //     int n = Convert.ToInt32(Console.ReadLine());
            //     int[] arrCost = Console.ReadLine().TrimEnd().Split(' ').ToArray().Select(irec => Convert.ToInt32(irec)).ToArray();
            //     Console.WriteLine(CalculateMinCost(n, arrCost));
            // }
            Console.WriteLine(test(2, 3));
            Console.WriteLine(calculate(5,5));
        }

        static double test(int a, int b) {
            return b == 0 ? 1 : Math.Pow(a, b) + test(a, b - 1);
            
        } 

        static int  calculate(int a, int b) {
            if (a == 0) return 0;
            return calculate(a - 1, b) + b;
        }

        static long CalculateMinCost(int n, int[] arrCost) {
            long totalCost = 0;
            if (n == 1)
            {
                return arrCost[0];
            }
            if (n == 2)
            {
                return Math.Max(arrCost[0],arrCost[1]);
            }
            if (n == 3)
            {
                return arrCost[0] + arrCost[1] + arrCost[2];
            }
            if (n > 3)
            {
                int k = n;
                Array.Sort(arrCost);
                while (k > 0)
                {
                    if (k == 1)
                    {
                        totalCost += arrCost[0];
                        break;
                    }
                    else if(k == 2)
                    {
                        totalCost += arrCost[1];
                        break;
                    }
                    else if (k == 3)
                    {
                        totalCost += arrCost[0] + arrCost[1] + arrCost[2];
                        break; 
                    }
                    else
                    {
                        if (arrCost[k - 2] + arrCost[0] > 2 * arrCost[1])
                        {
                            totalCost += (2 * arrCost[1]) + arrCost[k - 1] + arrCost[0];
                        }
                        else
                        {
                            totalCost += (arrCost[k - 2] + arrCost[0]) + arrCost[k - 1] + arrCost[0];
                        }
                    }
 
                    k = k - 2;
 
                }
            }
            return totalCost;
        }

        
    }
}
