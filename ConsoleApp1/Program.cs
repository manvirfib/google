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
            Operations operations = new Operations();
            var input = new List<Employee>();

            input.Add(new Employee()
            {
                Id = 1,
                Department = "A",
                Name = "aa",
                Salary = 123
            });
            input.Add(new Employee()
            {
                Id = 2,
                Department = "A",
                Name = "aa",
                Salary = 123
            });
            operations.GetAveragePerDepartment(input);
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
