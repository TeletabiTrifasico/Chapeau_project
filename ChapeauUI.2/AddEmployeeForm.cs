using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauService;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChapeauUI._2
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> employeeValues = new() {textBox4.Text, textBox1.Text, textBox2.Text, textBox3.Text};

            try
            {
                AddEmployee(employeeValues);
                MessageBox.Show("Employee added!");
            }
            catch (Exception eu)
            {
                MessageBox.Show(eu.Message);
            }
        }
        private void AddEmployee(List<string> list)
        {
            if (list.Any(x => x == ""))
            {
                throw new Exception("Enter all values!");
            }
            else
            {
                EmployeeService employeeService = new();
                employeeService.AddEmployees(FillEmployee(list));
                Close();
            }
        }
        private Employee FillEmployee(List<string> list)
        {
            if (!int.TryParse(list[0], out int EmployeeId))
            {
                throw new ArgumentException("EmployeeId should be a valid integer!");
            }

            if (!int.TryParse(list[2], out int Password))
            {
                throw new ArgumentException("Password should be a valid integer!");
            }

            return new Employee(EmployeeId, list[1], Password, list[3]);
        }
    }
}
