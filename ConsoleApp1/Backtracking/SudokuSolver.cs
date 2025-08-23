namespace HelloWorld
{
    class SudokuSolver
    {
        int[,] arr;
        public SudokuSolver(int[,] arr)
        {
            this.arr = arr;
            Run(1, 1);
        }

        bool ValidNumber(int row, int column, int k)
        {
            for (int i = 1; i < 10; i++) if (arr[row, i] == k) return false;
            for (int i = 1; i < 10; i++) if (arr[i, column] == k) return false;
            int l = ((row - 1) / 3) * 3;
            int h = ((column - 1) / 3) * 3;
            for (int i = l + 1; i <= (l + 3); i++)
            {
                for (int j = h + 1; j <= (h + 3); j++)
                {
                    if (arr[i, j] == k)
                        return false;
                }
            }

            return true;
        }
        void Run(int i, int j)
        {
            if (i == 10 && j == 1)
            {
                Console.WriteLine();
                for (int a = 1; a < 10; a++)
                {
                    for (int b = 1; b < 10; b++)
                    {
                        Console.Write(arr[a, b] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                return;
            }
            if (arr[i, j] != 0)
            {
                Run(j == 9 ? i + 1 : i, j == 9 ? 1 : j + 1);
            }
            else
            {
                for (int k = 1; k < 10; k++)
                {
                    if (ValidNumber(i, j, k))
                    {
                        arr[i, j] = k;
                        Run(j == 9 ? i + 1 : i, j == 9 ? 1 : j + 1);
                        arr[i, j] = 0;
                    }
                }
            }
        }
    }
}