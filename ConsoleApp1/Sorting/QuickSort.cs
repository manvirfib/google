using System.Runtime.InteropServices;

namespace HelloWorld
{
    class QuickSort
    {
        public void Sort(int[] A, int i, int j)
        {
            if (i == j)
                return;
            int m = i;
            int n = j;
            if (i >= j)
                return;
            int pivot = i;
            i++;
            while (j >= i)
            {
                if (A[i] < A[pivot])
                {
                    i++;
                }
                if (A[j] > A[pivot])
                {
                    j--;
                }
                if (i > n)
                    break;
                if (A[i] > A[pivot] && A[j] <= A[pivot])
                    {
                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                        i++;
                        j--;
                    }
            }
            int t = A[j];
            A[pivot] = A[j];
            A[j] = t;
            Sort(A, m, j - 1);
            Sort(A, j + 1, n);
        }
    }
}