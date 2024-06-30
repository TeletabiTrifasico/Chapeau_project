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
        public List<Employee> GetEmployees()
        {
            return employeeDao.GetAll();
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
