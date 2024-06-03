using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class EmployeeService
    {

        private EmployeeDao employeeDao;

     
        //constructor
        public EmployeeService()
        {
            employeeDao = new EmployeeDao();
        }

        // get GetEmployees method from EmployeeDao and assign it a list.
        public List<Employee> GetEmployees()
        {
            List<Employee> employees=employeeDao.GetEmployee();
            return employees;
        }

        // Delete students from the database
        public void DeleteEmployees(Employee employee)
        {
            employeeDao.DeleteEmployee(employee);
        }

        // Add students from the database
        public void AddEmployees(Employee employee)
        {
            employeeDao.AddEmployee(employee);
        }

        // Update students from the database
        public void UpdateEmployees(Employee employee)
        {
            employeeDao.UpdateEmployee(employee);
        }
    }
}
