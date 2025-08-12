namespace HelloWorld
{
    class Quick
    {
        int Partition(int[] A, int l, int h)
        {
            int pivot = A[l];
            int i = l, j = h;
            do
            {
                do { i++; } while (A[i] <= pivot);
                do { j--; } while (A[j] > pivot);
                if (i < j)
                {
                    int temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }
            } while (i < j);

            int t = A[j];
            A[l] = A[j];
            A[j] = t;

            return j;
        }

        public void Sort(int[] A, int l, int h)
        {
            if (l < h)
            {
                int j;
                j = Partition(A, l, h);
                Sort(A, l, j - 1);
                Sort(A, j + 1, h);
            }
        }
    }
}