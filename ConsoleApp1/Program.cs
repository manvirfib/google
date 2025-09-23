namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

            int i = 0, j = arr.Length - 1;
            int temp;

            while (i < j)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
        }
    }
}

/*


with cte as
(
select top(3) * from employee order by salary desc
),
select top(1) * from cte order by salary;
*/
