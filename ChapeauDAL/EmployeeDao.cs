using ChapeauModel;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;


namespace ChapeauDAL
{
    public class EmployeeDao : BaseDao<Employee>
    {
        internal protected override Employee ConvertItem(DataRow reader)
        {
            int EmployeeId = (int)reader["employeeId"];
            string Username = (string)reader["userName"];
            int Password = (int)reader["password"];
            string EmployeeRole = (string)reader["role"];


            return new Employee(EmployeeId, Username, Password, EmployeeRole);
        }
        private protected override string GetAllQuery()
        {
            return "SELECT employeeId, userName, password, role  FROM [employee]";
        }
        private SqlParameter[] EmployeeParameters(Employee employee)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@employeeId", SqlDbType.Int) {Value = employee.EmployeeId},
                new("@userName", SqlDbType.VarChar) {Value = employee.Username},
                new("@password", SqlDbType.VarChar) {Value = employee.Password},
                new("@role", SqlDbType.VarChar) {Value = employee.EmployeeRole},
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

            string query = "INSERT employee(userName, password, role) VALUES (@userName, @password, @role)";

            ExecuteEditQuery(query, EmployeeParameters(employee));
        }
    }
}
