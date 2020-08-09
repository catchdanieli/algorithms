using System;
using System.Linq;

namespace IslandCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            char[,] matrix = new char[size, size];
            
            for(int i = 0; i < size; i++) {
                string temp = Console.ReadLine();
                string[] tempArray = temp.Split(" ").Select(x => x.Trim()).ToArray();
                for(int j = 0; j < tempArray.Length; j++){
                    matrix[i,j] = tempArray[j][0];
                }                
            }

            IslandCounter ic = new IslandCounter (matrix);
            Console.WriteLine(ic.NumIslands());
        }
        
    }
}
