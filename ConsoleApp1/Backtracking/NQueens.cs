namespace HelloWorld
{
    class NQueens
    {
        int[] place;
        int numberOfQueens;
        int[] result;
        public NQueens(int n)
        {
            place = new int[n + 1];
            numberOfQueens = n;
        }

        bool ValidPlace(int row, int column)
        {
            for (int k = 1; k < row; k++)
            {
                if (place[k] == column || ((row + column) == (k + place[k])) || (column - row) == (place[k] - k))
                    return false;
            }

            return true;
        }

        public void Display()
        {
            Run(1);
            foreach (var num in result)
            {
                Console.Write(num + " ");
            }
        }

        void Run(int n)
        {
            for (int i = 1; i <= numberOfQueens; i++)
            {
                if (ValidPlace(n, i))
                {
                    place[n] = i;
                    if (n == numberOfQueens)
                    {
                        result = place.ToArray();
                        return;
                    }
                    Run(n + 1);
                }
            }
        }
    }
}