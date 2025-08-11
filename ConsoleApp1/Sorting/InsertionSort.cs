namespace HelloWorld
{
    class InsertionSort
    {
        public void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 1; i < n; i++)
            {
                int j = i - 1;
                int x = arr[i];

                while (j >= 0 && arr[j] > x)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = x;
            }
        }
    }
}
//Insertio sort is adaptive and stable