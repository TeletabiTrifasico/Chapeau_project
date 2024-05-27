using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class TableService
    {
        private TableDao tableDao;

        //constructor
        public TableService()
        {
            tableDao = new TableDao();
        }

        // get "GetTables" method from TableDao.
        public List<Table> GetTables()
        {
            List<Table> tables = tableDao.GetTables();
            return tables;
        }
    }
}
