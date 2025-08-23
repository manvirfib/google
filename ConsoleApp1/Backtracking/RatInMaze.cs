namespace HelloWorld
{
    class RatInMaze
    {
        int[,] arr;
        int[,] result; 
        int path = 0;

        public RatInMaze(int[,] arr)
        {
            this.arr = arr;
            result = new int[2, arr.GetLength(0) * arr.GetLength(1)];
        }

        public void Run(int i, int j)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            // destination reached
            if (i == rows - 1 && j == cols - 1)
            {
                result[0, path] = i;
                result[1, path] = j;
                for (int k = 0; k <= path; k++)
                {
                    Console.Write($"({result[0, k]}, {result[1, k]}) ");
                }
                Console.WriteLine();
                return;
            }

            // mark visited
            arr[i, j] = -1;
            result[0, path] = i;
            result[1, path] = j;
            path++;

            // right
            if (j + 1 < cols && arr[i, j + 1] == 1)
                Run(i, j + 1);

            // down
            if (i + 1 < rows && arr[i + 1, j] == 1)
                Run(i + 1, j);

            // left
            if (j - 1 >= 0 && arr[i, j - 1] == 1)
                Run(i, j - 1);

            // up
            if (i - 1 >= 0 && arr[i - 1, j] == 1)
                Run(i - 1, j);

            // unmark (backtrack)
            arr[i, j] = 1;
            path--;
        }
    }
}
