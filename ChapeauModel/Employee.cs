using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Employee
    {
        public int EmployeeId { get; set; }                 //Employee Id (Primary key)
        public string Username { get; set; }                //Employee Username
        public int Password { get; set; }                   //Employee Password
        public Role EmployeeRole { get; set; }              //Employee Role (enum)

    }
}
