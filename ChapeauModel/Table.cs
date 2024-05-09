using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    internal class Table
    {
        private int TableId { get; set; }           //Table ID (Primary key)
        private int TableNumber { get; set; }       //The individual number of each table
        private string TableStatus { get; set; }    //The table status (it can be empty or taken)

    }
}
