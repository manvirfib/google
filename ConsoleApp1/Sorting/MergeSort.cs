namespace HelloWorld
{
    class MergeSort
    {
        public void Sort(int[] A, int l, int h)
        {
            if (l >= h)
                return;
            int mid = (l + h) / 2;
            Sort(A, l, mid);
            Sort(A, mid + 1, h);
            Merge(l, h, mid, A);
        }

        void Merge(int l, int h, int mid, int[] A)
        {
            int j = mid + 1;
            int i = l;
            int[] B = new int[A.Length];
            int k = l;

            while (i <= mid && j <= h)
            {
                if (A[i] > A[j])
                {
                    B[k++] = A[j++];
                }
                else
                {
                    B[k++] = A[i++];
                }
            }

            for (; i <= mid;)
            {
                B[k++] = A[i++];
            }

            for (; j <= h;)
            {
                B[k++] = A[j++];
            }

            for (int p = l; p <= h; p++)
            {
                A[p] = B[p];
            }
        }
    }
}