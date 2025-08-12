namespace HelloWorld
{
    class SelectionSort
    {
        public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int k = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[k])
                    {
                        k = j;
                    }
                }
                int temp = arr[k];
                arr[k] = arr[i];
                arr[i] = temp;
            }
        }
    }
}

//It is not Adaptive and Stable