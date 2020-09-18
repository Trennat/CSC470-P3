using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC470_P3EmployeeInfo
{
    public class FakeEmployeeRepository : IEmployeeRepository
    {
        private static Dictionary<int, Employee> Employees;
        public FakeEmployeeRepository()
        {
            if (Employees == null)
            {
                Employees = new Dictionary<int, Employee>();
                // Adding demo employees to use
                Employees.Add(1, new Employee
                {
                    id = 1,
                    lastName = "Tharp",
                    firstName = "Tanner",
                    salary = (decimal)52435.69
                });
                Employees.Add(2, new Employee
                {
                    id = 2,
                    lastName = "Davis",
                    firstName = "Miles",
                    salary = (decimal)999999.56
                });
            }
        }
        private int GetNextID()
        {
            int currentMaxID = 0;
            foreach (KeyValuePair<int, Employee> keyValuePair in Employees)
            {
                if (keyValuePair.Key > currentMaxID)
                {
                    currentMaxID = keyValuePair.Key;
                }
            }
            return ++currentMaxID;
        }
        public int Save(Employee Emp)
        {
            int id = GetNextID();
            Emp.id = id;
            Employees.Add(Emp.id, Emp);
            return id;
        }
        public List<Employee> GetAll()
        {
            List<Employee> emps = new List<Employee>();
            foreach (KeyValuePair<int, Employee> emp in Employees)
            {
                emps.Add(emp.Value);
            }
            return emps;
        }
        public decimal GetSalary(int id)
        {
            decimal salary = (decimal)-1.0;
            Employee emp;
            if (Employees.TryGetValue(id,out emp))
            {
                salary = emp.salary;
            }
            return salary;
        }
        public Employee GetByID(int id)
        {
            Employee emp;
            bool ignore = Employees.TryGetValue(id, out emp);
            return emp;
        }
    }
}
