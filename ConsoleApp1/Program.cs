namespace HelloWorld
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }

    class Operations
    {
        List<Employee> listOfEmployees = new List<Employee>();
        public List<Employee> GetEmployeesWithHighestSalary(List<Employee> list)
        {
            double maxSalary = list.Max(x => x.Salary);

            return new List<Employee>(list.Where(x => x.Salary == maxSalary));
        }

        public List<Employee> GetEmployees(List<Employee> list)
        {
            return new List<Employee>(list.Where(x => x.Name.StartsWith("A")).OrderByDescending(x => x.Salary));
        }

        public void GetAveragePerDepartment(List<Employee> list)
        {
            var result = list.GroupBy(x => x.Department);
        }
    }
    /*

    select department_id, avg(Salary) as average from employee group by department
    */
    class Program
    {
        static void Main(string[] args)
        {
            Fibbo fb = new();
            int n = 5;
            int[] dp = new int[n + 1];
            Array.Fill(dp, -1);
            dp[0] = 1;
            dp[1] = 1;
            Console.WriteLine("Fibbo: " + fb.fib(n, dp));
        }
    }
}