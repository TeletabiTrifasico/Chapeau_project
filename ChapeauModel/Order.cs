using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    internal class Order
    {
        private int OrderId { get; set; }           //Order ID (Primary key)
        private int BillNumber { get; set; }        //Bill number (Foreign key from Bill)
        private int TableId { get; set;}            //Table ID (Foreign key from Table)
        private int EmployeeId { get; set; }        //Employee ID (Foreign key from Employee)
        private string Command { get; set; }        //Command to add or remove an ingredient from an order

        public Order(int orderId, int billNumber, int tableId, int employeeId, string command)
        {
            OrderId = orderId;
            BillNumber = billNumber;
            TableId = tableId;
            EmployeeId = employeeId;
            Command = command;

            
        }
    }

}


    

