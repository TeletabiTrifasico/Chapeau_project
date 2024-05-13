using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    internal class Bill
    {
        private int BillNumber { get; set; }        //Bill number (Primary key)
        private string PaymentMethod { get; set; }  //The bills payment method
        private float Amount { get; set; }          //The bills amount to be payed
        private int Vat { get; set; }               //The bills VAT amount
        private string Comment { get; set; }        //A comment in the bill

    }
}
