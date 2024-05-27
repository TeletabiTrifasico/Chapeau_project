using ChapeauModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class EmployeeDao : BaseDao
    {
        //sql query to get employee information.
        public List<Employee> GetEmployees()
        {
            string query = "SELECT employeeId, userName, password, role  FROM [employee]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
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
        private SqlParameter[] EmployeeParameters(Employee employee)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@employeeId", SqlDbType.Int) {Value = employee.EmployeeId},
                new("@userName", SqlDbType.VarChar) {Value = employee.Username},
                new("@password", SqlDbType.VarChar) {Value = employee.Password},
                new("@role", SqlDbType.VarChar) {Value = employee.Role},
            };

            return parameters;
        }
        public void UpdateEmployee(Employee employee)
        {
            string query = "UPDATE employee SET userName = @userName, password = @password, role = @role WHERE employeeId = @employeeId";
            ExecuteEditQuery(query, EmployeeParameters(employee));
        }
        public void DeleteEmployee(Employee employee)
        {
            string query = "DELETE FROM employee WHERE employeeId = @employeeId";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@student_number", SqlDbType.Int) {Value = employee.EmployeeId}
            };

            ExecuteEditQuery(query, parameters);
        }
        private void CheckEmployeeValues(Employee employee)
        {
            if (IdExists(employee.EmployeeId, "employee", "employeeId"))
            {
                throw new Exception("This id already exists!");
            }
        }
        public void AddEmployee(Employee employee)
        {
            CheckEmployeeValues(employee);

            string query = "INSERT student(student_number, first_name, last_name, class, phone_number, roomID) VALUES (@student_number, @first_name, @last_name, @class, @phone_number, @roomID)";

            ExecuteEditQuery(query, EmployeeParameters(employee));
        }
    }
}
