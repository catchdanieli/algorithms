using System;

namespace IslandCounter{
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
            int size = 0;
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