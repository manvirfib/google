namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
