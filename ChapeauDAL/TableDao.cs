using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauDAL
{
    public class TableDao :BaseDao
    {









        private List<Employee> RadTables(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Employee employee = new Employee()
                {
                    EmployeeId = (int)dr["employeeId"],
                    Username = dr["name"].ToString(),
                    Password = (int)dr["password"],
                    Role = dr["role"].ToString()
                };
                employees.Add(employee);
            }
            return employees;
        }


        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables= new List<Table>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table()
                {

                }






            }
        }




    }
}
