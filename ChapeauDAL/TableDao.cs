using ChapeauModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class TableDao : BaseDao
    {
       
        public List<Table> GetTables()
        {
            string query = "SELECT tableId, tableNumber, tableStatus FROM[table]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table()
                {
                    TableId = (int)dr["tableId"],
                    TableNumber = (int)dr["tableNumber"],
                    TableStatus = dr["tableStatus"].ToString()
                };
                tables.Add(table);
            }
            return tables;
        }
    }

}

