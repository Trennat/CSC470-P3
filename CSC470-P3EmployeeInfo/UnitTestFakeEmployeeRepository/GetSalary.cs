using CSC470_P3EmployeeInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestFakeEmployeeRepository
{
    public class GetSalary
    {
        public void GetSalaryWithGoodIdIsCorrect()
        {
            // Arrange
            const int ID = 1;
            const decimal EXPECTED_SALARY = (decimal)52435.69;
            FakeEmployeeRepository EmpRepository = new FakeEmployeeRepository;
            
            // Act
            decimal actualSalary = EmpRepository.GetSalary(ID);

            //Assert
            Assert.AreEqual(EXPECTED_SALARY, actualSalary);
        }
    }
}
