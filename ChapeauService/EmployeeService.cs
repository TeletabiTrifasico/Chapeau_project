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
            List<Employee> employees=employeeDao.GetEmployees();
            return employees;
        }

        // Delete students from the database
        public void DeleteStudent(Employee employee)
        {
            employeeDao.DeleteEmployee(employee);
        }

        // Add students from the database
        public void AddStudent(Employee employee)
        {
            employeeDao.AddEmployee(employee);
        }

        // Update students from the database
        public void UpdateStudent(Employee employee)
        {
            employeeDao.UpdateEmployee(employee);
        }
    }
}
