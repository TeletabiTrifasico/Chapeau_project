using ChapeauModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class EmployeeDao : BaseDao
    {

        // to be able to manage employees(add,update)
        public List<Employee> GetEmployees()
        {
            string query = "SELECT employeeId, userName, password, role  FROM [employee]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //public List<Employee> GetEmployeeUserName()
        //{
        //    string query = "SELECT userName FROM [employee]";
        //    SqlParameter[] sqlParameters = new SqlParameter[0];
        //    return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        //}

        //public List<Employee> GetEmployeePassword()
        //{
        //    string query = "SELECT password FROM [employee]";
        //    SqlParameter[] sqlParameters = new SqlParameter[0];
        //    return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        //}


        private List<Employee> ReadTables(DataTable dataTable)
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
    }
}
