using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC470_P3EmployeeInfo
{
    public interface IEmployeeRepository
    {
        int Save(Employee Emp);
        List<Employee> GetAll();
        decimal GetSalary(int ID);
        Employee GetByID(int ID);
    }
}
