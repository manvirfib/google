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
            Disjoint ds = new Disjoint(7);
            ds.Union(1, 2);
            ds.Union(2, 3);
            ds.Union(4, 5);
            ds.Union(6, 7);
            ds.Union(5, 6);
            if (ds.FindParent(3) != ds.FindParent(7))
                Console.WriteLine("Not same");
            ds.Union(3, 7);
            if (ds.FindParent(3) == ds.FindParent(7))
                Console.WriteLine("same");
        }
    }
}