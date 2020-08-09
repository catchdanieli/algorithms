    using System;
using System.Linq;

namespace islandcounter2
{
    class Program
    {
        public static void Main()
        {
            int size = Convert.ToInt32(Console.ReadLine());
            char[,] matrix = new char[size, size];

            for(int i = 0; i < size; i++) {
                string temp = Console.ReadLine();
                string[] tempArray = temp.Split(' ').Select(x => x.Trim()).ToArray();
                for(int j = 0; j < tempArray.Length; j++){
                    matrix[i,j] = tempArray[j][0];
                }                
            }

            IslandCounter ic = new IslandCounter (matrix);
            Console.WriteLine(ic.NumIslands());
        }
    }


    public class IslandCounter
    {
        public IslandCounter(char[,] matrix)
        {
            grid = matrix;
        }
        private int count = 0;
        private bool[,] visited;
        int max_Size = 0;
        // 3
        private char[,] grid ;
        public int NumIslands()
        {
            int size;
            var rows = grid.GetLength(0);
            var columns = grid.GetLength(1);

            visited = new bool[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (grid[i, j] == 'T' && !visited[i,j])
                    {
                        size = this.NumIslandsHelper(grid, i, j, 0);                   
                        count++;
                    }
                }
            }

            return max_Size;
        }

        private int NumIslandsHelper(char[,] grid, int i, int j, int size)
        {
            if (i < 0 || i >= grid.GetLength(0)) return size;
            if (j < 0 || j >= grid.GetLength(1)) return size;
            if (visited[i, j]) 
            {
                return size;
            }
            if (grid[i, j] != 'T') return size;

            visited[i, j] = true;
            size++;
            if(size > max_Size) max_Size = size;         

            size = this.NumIslandsHelper(grid, i - 1, j, size); // above
            size = this.NumIslandsHelper(grid, i + 1, j, size); // below
            size = this.NumIslandsHelper(grid, i, j - 1, size); // left
            size = this.NumIslandsHelper(grid, i, j + 1, size); // right
            // size = this.NumIslandsHelper(grid, i-1, j-1, size); // above left
            // size = this.NumIslandsHelper(grid, i-1, j+1, size); // above right
            // size = this.NumIslandsHelper(grid, i+1, j-1, size); // below left
            // size = this.NumIslandsHelper(grid, i+1, j+1, size); // below right

            return size;
        }    

    }


    
}
