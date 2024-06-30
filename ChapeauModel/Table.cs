using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Table
    {
        public int TableId { get; set; }           //Table ID (Primary key)
        public int TableNumber { get; set; }       //The individual number of each table
        public string TableStatus { get; set; }    //The table status (it can be empty or taken)
        public Table(){}
        public Table(int tableId, int tableNumber, string tableStatus)
        {
            TableId = tableId;
            TableNumber = tableNumber;
            TableStatus = tableStatus;
        }
    }
}
